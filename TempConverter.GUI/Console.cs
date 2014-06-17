using System.Windows.Forms;
using TempConverter.GUI.EventArgs;
using TempConverter.Model;
using TempConverter.Model.Domain;

namespace TempConverter.GUI
{
    public partial class Console : Form
    {
        private readonly PanelPainter _fahrenheitPainter;

        private readonly PanelPainter _celsiusPainter;

        private readonly PanelPainter _kelvinPainter;

        private readonly StandardConverter _tempConverter;
        

        public Console(StandardConverter tempConverter)
        {
            _fahrenheitPainter = new PanelPainter();
            _celsiusPainter = new PanelPainter();
            _kelvinPainter = new PanelPainter();
            _tempConverter = tempConverter;

            InitializeComponent();
            InitialiseScaleLabels();
            CreateLabelToolTips();
            CalculateTemperatures();
            _panelCelcius.Refresh();
        }

        private void InitialiseScaleLabels()
        {
            _lblMinTemp.Text = _sliderBar.TempScale.Minimum.ToString();
            _lblZero.Text = "0";
            _lblMaxTemp.Text = _sliderBar.TempScale.Maximum.ToString();
        }

        private void CreateLabelToolTips()
        {
            var fahrenheitTTip = new ToolTip();
            fahrenheitTTip.SetToolTip(_lblFahrenheit, "Fahrenheit");

            var celsiusTTip = new ToolTip();
            celsiusTTip.SetToolTip(_lblCelsius, "Celsius");

            var kelvinTTip = new ToolTip();
            kelvinTTip.SetToolTip(_lblKelvin, "Kelvin");
        }

        private void OnTrackBarScroll(object sender, System.EventArgs e)
        {
            CalculateTemperatures();
        }        //ambig method name with one below        private void CalculateTemperatures()
        {
            double fahrenheit = _sliderBar.Value;
            Temperature<double> temperatures = CalculateTemperatureValues(fahrenheit);

            //side effects
            UpdateTemperatureLabels(temperatures);
            PaintTemperaturePanels(temperatures);
        }
        private Temperature<double> CalculateTemperatureValues(double baseTemp, int roundBy = 0)
        {
            if(RoundingIsNeeded())
                roundBy = 2;

            double f = baseTemp;
            double c = _tempConverter.ConvertTemperature(baseTemp, StandardConverter.FahrenheitToCelsius, roundBy);
            double k = _tempConverter.ConvertTemperature(baseTemp, StandardConverter.FahrenheitToKelvin, roundBy);

            return new Temperature<double>(f, c, k);
        }

        private bool RoundingIsNeeded()
        {
            return !_checkBoxRound.Checked;
        }

        private void UpdateTemperatureLabels(Temperature<double> temperature)
        {
            _lblFahrenheitValue.Text = temperature.Fahrenheit.ToString();
            _lblCelsiusValue.Text = temperature.Celsius.ToString();
            _lblKelvinValue.Text = temperature.Kelvin.ToString();
        }

        private void PaintTemperaturePanels(Temperature<double> temperature)
        {
            PaintFahrenheitPanel(null, new PanelPaintEventArgs(_panelFahrenheit.CreateGraphics(), temperature));
            PaintCelsiusPanel(null, new PanelPaintEventArgs(_panelCelcius.CreateGraphics(), temperature));
            PaintKelvinPanel(null, new PanelPaintEventArgs(_panelKelvin.CreateGraphics(), temperature));
        }

        private void PaintFahrenheitPanel(object sender, PaintEventArgs e)
        {
            var panelPaint = e as PanelPaintEventArgs;
            if (panelPaint == null) return;

            _fahrenheitPainter.PaintPanels(e, panelPaint.Temperatures.Fahrenheit);
        }

        private void PaintCelsiusPanel(object sender, PaintEventArgs e)
        {
            var panelPaint = e as PanelPaintEventArgs;
            if (panelPaint == null) return;

            _celsiusPainter.PaintPanels(e, panelPaint.Temperatures.Celsius);
        }

        private void PaintKelvinPanel(object sender, PaintEventArgs e)
        {
            var panelPaint = e as PanelPaintEventArgs;
            if (panelPaint == null) return;

            _kelvinPainter.PaintPanels(e, panelPaint.Temperatures.Kelvin);
        }

        private void RoundTemperatureCheckBoxChanged(object sender, System.EventArgs e)
        {
           Temperature<double> temperatures = CalculateTemperatureValues(_sliderBar.Value);         
           
           UpdateTemperatureLabels(temperatures);
           PaintTemperaturePanels(temperatures);
        }

    }
}
