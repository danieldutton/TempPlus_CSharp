using System.Windows.Forms;
using TempConverter.GUI.EventArgs;
using TempConverter.Model;
using TempConverter.Model.Domain;
using TempConverter.Model.Interfaces;

namespace TempConverter.GUI
{
    public partial class Console : Form
    {
        private readonly ITemperatureConverter _tempConverter;

        private readonly PanelPainter _fahrenheitPainter;

        private readonly PanelPainter _celsiusPainter;

        private readonly PanelPainter _kelvinPainter;
        
        private Scale<int> _scale;


        public Console(ITemperatureConverter tempConverter, Scale<int> scale)
        {
            _tempConverter = tempConverter;
            _scale = scale;

            _fahrenheitPainter = new PanelPainter();
            _celsiusPainter = new PanelPainter();
            _kelvinPainter = new PanelPainter();
            
            InitializeComponent();  
            InitialiseScaleLabels();
            InitialiseLabelToolTips();  
        }

        private void InitialiseScaleLabels()
        {
            _lblMinTemp.Text = _scale.Minimum.ToString();
            _lblZero.Text = "0";
            _lblMaxTemp.Text = _scale.Maximum.ToString();
        }

        private void InitialiseLabelToolTips()
        {
            var fahrenheitTTip = new ToolTip();
            fahrenheitTTip.SetToolTip(_lblFahrenheit, "Fahrenheit");

            var celsiusTTip = new ToolTip();
            celsiusTTip.SetToolTip(_lblCelsius, "Celsius");

            var kelvinTTip = new ToolTip();
            kelvinTTip.SetToolTip(_lblKelvin, "Kelvin");
        }

        protected override void OnPaint(PaintEventArgs e)
        {         
            base.OnPaint(e);
            CalculateTemperatures();
        }

        private void OnTrackBarScroll(object sender, System.EventArgs e)
        {
            CalculateTemperatures();
        }        private void CalculateTemperatures()
        {
            double fahrenheit = _sliderBar.Value;
            Temperature<double> temperatures = CalculateTemperatureValues(fahrenheit);

            UpdateTemperatureLabels(temperatures);
            PaintTemperaturePanels(temperatures);
        }
        private Temperature<double> CalculateTemperatureValues(double baseTemp, int roundBy = 0)
        {
            if(RoundingIsNeeded())
                roundBy = 2;

            double f = baseTemp;
            double c = _tempConverter.ConvertTemperature(baseTemp, TemperatureConverter.FahrenheitToCelsius, roundBy);
            double k = _tempConverter.ConvertTemperature(baseTemp, TemperatureConverter.FahrenheitToKelvin, roundBy);

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
            //can we force paint direct without all this shizzle
            PaintFahrenheitPanel(null, new PanelPaintEventArgs(_panelFahrenheit.CreateGraphics(), temperature));
            PaintCelsiusPanel(null, new PanelPaintEventArgs(_panelCelcius.CreateGraphics(), temperature));
            PaintKelvinPanel(null, new PanelPaintEventArgs(_panelKelvin.CreateGraphics(), temperature));
        }

        private void PaintFahrenheitPanel(object sender, PaintEventArgs e)
        {
            var panelPaint = e as PanelPaintEventArgs;
            if (panelPaint == null) return;

            _fahrenheitPainter.PaintFahrenheitPanel(e, panelPaint.Temperatures.Fahrenheit);
        }

        private void PaintCelsiusPanel(object sender, PaintEventArgs e)
        {
            var panelPaint = e as PanelPaintEventArgs;
            if (panelPaint == null) return;

            _celsiusPainter.PaintFahrenheitPanel(e, panelPaint.Temperatures.Celsius);
        }

        private void PaintKelvinPanel(object sender, PaintEventArgs e)
        {
            var panelPaint = e as PanelPaintEventArgs;
            if (panelPaint == null) return;

            _kelvinPainter.PaintFahrenheitPanel(e, panelPaint.Temperatures.Kelvin);
        }

        private void CheckBoxRoundCheckedChanged(object sender, System.EventArgs e)
        {
           Temperature<double> temperatures = CalculateTemperatureValues(_sliderBar.Value);         
           
           UpdateTemperatureLabels(temperatures);
        }

    }
}
