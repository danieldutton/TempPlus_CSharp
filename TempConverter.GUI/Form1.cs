using System.Windows.Forms;
using TempConverter.GUI.EventArgs;
using TempConverter.Model;
using TempConverter.Model.Domain;
using TempConverter.Model.Interfaces;

namespace TempConverter.GUI
{
    public partial class Form1 : Form
    {
        private readonly ITemperatureConverter _tempConverter;
        
        private Scale<int> _scale;

        private const int GraphBarHeight = 8;

        public Form1(ITemperatureConverter tempConverter, Scale<int> scale)
        {
            _tempConverter = tempConverter;
            _scale = scale;
            
            InitializeComponent();  
            InitialiseLabels();
            InitialiseLabelToolTips();  
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateTemperatureValues();          
            base.OnPaint(e);
        }        private void UpdateTemperatureValues()
        {
            double farenheit = _sliderBar.Value;
            Temperature<double> temperatures = CalculateTemperatureValues(farenheit);

            UpdateTemperatureLabels(temperatures);
            FirePanelPaintingEvents(temperatures);
        }
        private void InitialiseLabels()
        {
            _lblSlideBarMinTempValue.Text = _scale.Minimum.ToString();
            _lblSlideBarZeroTempValue.Text = "0";
            _lblSlideBarMaxTempValue.Text = _scale.Maximum.ToString();             
        }

        private void InitialiseLabelToolTips()
        {
            var fahrenheitTTip = new ToolTip();
            fahrenheitTTip.SetToolTip(_lblFarenheit, "Fahrenheit");

            var celsiusTTip = new ToolTip();
            celsiusTTip.SetToolTip(_lblCelcius, "Celsius");

            var kelvinTTip = new ToolTip();
            kelvinTTip.SetToolTip(_lblKelvin, "Kelvin");
        }
     
        private void OnTrackBarScrolling(object sender, System.EventArgs e)
        {
            UpdateTemperatureValues();
        }

        private Temperature<double> CalculateTemperatureValues(double baseTemp, int roundBy = 0)
        {
            if(!_checkBoxRound.Checked)
                roundBy = 2;

            return new Temperature<double>
            {
                Fahrenheit = baseTemp,
                Celsius = _tempConverter.ConvertTemperature(baseTemp, TemperatureConverter.FahrenheitToCelsius, roundBy),
                Kelvin = _tempConverter.ConvertTemperature(baseTemp, TemperatureConverter.FahrenheitToKelvin, roundBy),
            };
        }

        private void UpdateTemperatureLabels(Temperature<double> temperature)
        {
            _lblFahrenheitValue.Text = temperature.Fahrenheit.ToString();
            _lblCelciusValue.Text = temperature.Celsius.ToString();
            _lblKelvinValue.Text = temperature.Kelvin.ToString();
        }

        private void FirePanelPaintingEvents(Temperature<double> temperature)
        {
            PaintFahrenheitPanel(null, new PanelPaintEventArgs(_panelFahrenheit.CreateGraphics(), temperature));
            PaintCelsiusPanel(null, new PanelPaintEventArgs(_panelCelcius.CreateGraphics(), temperature));
            PaintKelvinPanel(null, new PanelPaintEventArgs(_panelKelvin.CreateGraphics(), temperature));
        }

        private void PaintFahrenheitPanel(object sender, PaintEventArgs e)
        {
            var panelPainter = new PanelPainter(GraphBarHeight);
            panelPainter.PaintFahrenheitPanel(e, _scale);
        }

        private void PaintCelsiusPanel(object sender, PaintEventArgs e)
        {
            var panelPainter = new PanelPainter(GraphBarHeight);
            panelPainter.PaintCelsiusPanel(e, _scale);
        }

        private void PaintKelvinPanel(object sender, PaintEventArgs e)
        {
            var panelPainter = new PanelPainter(GraphBarHeight);
            panelPainter.PaintKelvinPanel(e, _scale);                
        }

        private void CheckBoxRoundCheckedChanged(object sender, System.EventArgs e)
        {
           Temperature<double> temperatures = CalculateTemperatureValues(_sliderBar.Value);         
            UpdateTemperatureLabels(temperatures);
        }

    }
}
