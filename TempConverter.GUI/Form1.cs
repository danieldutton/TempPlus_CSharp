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

        private readonly PanelPainter _panelPainter;
        
        private Scale<int> _scale;

        private const int GraphBarHeight = 8;


        public Console(ITemperatureConverter tempConverter, Scale<int> scale)
        {
            _tempConverter = tempConverter;
            _panelPainter = new PanelPainter(GraphBarHeight);
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
            _lblCelsiusValue.Text = temperature.Celsius.ToString();
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
            _panelPainter.PaintFahrenheitPanel(e, _scale);
        }

        private void PaintCelsiusPanel(object sender, PaintEventArgs e)
        {
            _panelPainter.PaintCelsiusPanel(e, _scale);
        }

        private void PaintKelvinPanel(object sender, PaintEventArgs e)
        {
            _panelPainter.PaintKelvinPanel(e, _scale);                
        }

        private void CheckBoxRoundCheckedChanged(object sender, System.EventArgs e)
        {
           Temperature<double> temperatures = CalculateTemperatureValues(_sliderBar.Value);         
           
           UpdateTemperatureLabels(temperatures);
        }

    }
}
