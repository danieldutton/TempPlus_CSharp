
using TempConverter.Model.Domain;

namespace TempConverter.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._lblFahrenheitValue = new System.Windows.Forms.Label();
            this._lblKelvinValue = new System.Windows.Forms.Label();
            this._lblCelciusValue = new System.Windows.Forms.Label();
            this._lblRoundValues = new System.Windows.Forms.Label();
            this._checkBoxRound = new System.Windows.Forms.CheckBox();
            this._lblSlideBarMinTempValue = new System.Windows.Forms.Label();
            this._lblSlideBarMaxTempValue = new System.Windows.Forms.Label();
            this._lblSlideBarZeroTempValue = new System.Windows.Forms.Label();
            this._panelFahrenheit = new System.Windows.Forms.Panel();
            this._panelCelcius = new System.Windows.Forms.Panel();
            this._panelKelvin = new System.Windows.Forms.Panel();
            this._lblKelvin = new System.Windows.Forms.Label();
            this._lblCelcius = new System.Windows.Forms.Label();
            this._lblFarenheit = new System.Windows.Forms.Label();
            this._sliderBar = new TempConverter.GUI.Components.NoFocusTrackBar(new Scale<int> {Minimum = -150, Maximum = 150, ScaleBy = 3});
            ((System.ComponentModel.ISupportInitialize)(this._sliderBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblFahrenheitValue
            // 
            this._lblFahrenheitValue.AutoSize = true;
            this._lblFahrenheitValue.BackColor = System.Drawing.Color.Transparent;
            this._lblFahrenheitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFahrenheitValue.ForeColor = System.Drawing.Color.White;
            this._lblFahrenheitValue.Location = new System.Drawing.Point(149, 64);
            this._lblFahrenheitValue.Name = "_lblFahrenheitValue";
            this._lblFahrenheitValue.Size = new System.Drawing.Size(13, 13);
            this._lblFahrenheitValue.TabIndex = 1;
            this._lblFahrenheitValue.Text = "0";
            // 
            // _lblKelvinValue
            // 
            this._lblKelvinValue.AutoSize = true;
            this._lblKelvinValue.BackColor = System.Drawing.Color.Transparent;
            this._lblKelvinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblKelvinValue.ForeColor = System.Drawing.Color.White;
            this._lblKelvinValue.Location = new System.Drawing.Point(149, 110);
            this._lblKelvinValue.Name = "_lblKelvinValue";
            this._lblKelvinValue.Size = new System.Drawing.Size(13, 13);
            this._lblKelvinValue.TabIndex = 1;
            this._lblKelvinValue.Text = "0";
            // 
            // _lblCelciusValue
            // 
            this._lblCelciusValue.AutoSize = true;
            this._lblCelciusValue.BackColor = System.Drawing.Color.Transparent;
            this._lblCelciusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCelciusValue.ForeColor = System.Drawing.Color.White;
            this._lblCelciusValue.Location = new System.Drawing.Point(149, 86);
            this._lblCelciusValue.Name = "_lblCelciusValue";
            this._lblCelciusValue.Size = new System.Drawing.Size(13, 13);
            this._lblCelciusValue.TabIndex = 1;
            this._lblCelciusValue.Text = "0";
            // 
            // _lblRoundValues
            // 
            this._lblRoundValues.AutoSize = true;
            this._lblRoundValues.Font = new System.Drawing.Font("Rod", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRoundValues.ForeColor = System.Drawing.Color.White;
            this._lblRoundValues.Location = new System.Drawing.Point(8, 132);
            this._lblRoundValues.Name = "_lblRoundValues";
            this._lblRoundValues.Size = new System.Drawing.Size(38, 14);
            this._lblRoundValues.TabIndex = 4;
            this._lblRoundValues.Text = "Round";
            // 
            // _checkBoxRound
            // 
            this._checkBoxRound.AutoSize = true;
            this._checkBoxRound.FlatAppearance.BorderSize = 0;
            this._checkBoxRound.Location = new System.Drawing.Point(48, 132);
            this._checkBoxRound.Name = "_checkBoxRound";
            this._checkBoxRound.Size = new System.Drawing.Size(15, 14);
            this._checkBoxRound.TabIndex = 5;
            this._checkBoxRound.UseVisualStyleBackColor = true;
            this._checkBoxRound.CheckedChanged += new System.EventHandler(this.CheckBoxRoundCheckedChanged);
            // 
            // _lblSlideBarMinTempValue
            // 
            this._lblSlideBarMinTempValue.AutoSize = true;
            this._lblSlideBarMinTempValue.Font = new System.Drawing.Font("Trebuchet MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSlideBarMinTempValue.ForeColor = System.Drawing.Color.Red;
            this._lblSlideBarMinTempValue.Location = new System.Drawing.Point(9, 44);
            this._lblSlideBarMinTempValue.Name = "_lblSlideBarMinTempValue";
            this._lblSlideBarMinTempValue.Size = new System.Drawing.Size(25, 15);
            this._lblSlideBarMinTempValue.TabIndex = 6;
            this._lblSlideBarMinTempValue.Text = "-150";
            // 
            // _lblSlideBarMaxTempValue
            // 
            this._lblSlideBarMaxTempValue.AutoSize = true;
            this._lblSlideBarMaxTempValue.Font = new System.Drawing.Font("Trebuchet MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSlideBarMaxTempValue.ForeColor = System.Drawing.Color.Yellow;
            this._lblSlideBarMaxTempValue.Location = new System.Drawing.Point(278, 44);
            this._lblSlideBarMaxTempValue.Name = "_lblSlideBarMaxTempValue";
            this._lblSlideBarMaxTempValue.Size = new System.Drawing.Size(22, 15);
            this._lblSlideBarMaxTempValue.TabIndex = 7;
            this._lblSlideBarMaxTempValue.Text = "150";
            // 
            // _lblSlideBarZeroTempValue
            // 
            this._lblSlideBarZeroTempValue.AutoSize = true;
            this._lblSlideBarZeroTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSlideBarZeroTempValue.ForeColor = System.Drawing.Color.RoyalBlue;
            this._lblSlideBarZeroTempValue.Location = new System.Drawing.Point(150, 45);
            this._lblSlideBarZeroTempValue.Name = "_lblSlideBarZeroTempValue";
            this._lblSlideBarZeroTempValue.Size = new System.Drawing.Size(10, 12);
            this._lblSlideBarZeroTempValue.TabIndex = 7;
            this._lblSlideBarZeroTempValue.Text = "0";
            // 
            // _panelFahrenheit
            // 
            this._panelFahrenheit.Location = new System.Drawing.Point(29, 66);
            this._panelFahrenheit.Name = "_panelFahrenheit";
            this._panelFahrenheit.Size = new System.Drawing.Size(113, 13);
            this._panelFahrenheit.TabIndex = 3;
            this._panelFahrenheit.TabStop = true;
            this._panelFahrenheit.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintFahrenheitPanel);
            // 
            // _panelCelcius
            // 
            this._panelCelcius.Location = new System.Drawing.Point(29, 89);
            this._panelCelcius.Name = "_panelCelcius";
            this._panelCelcius.Size = new System.Drawing.Size(113, 13);
            this._panelCelcius.TabIndex = 3;
            this._panelCelcius.TabStop = true;
            this._panelCelcius.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCelsiusPanel);
            // 
            // _panelKelvin
            // 
            this._panelKelvin.Location = new System.Drawing.Point(29, 113);
            this._panelKelvin.Name = "_panelKelvin";
            this._panelKelvin.Size = new System.Drawing.Size(113, 13);
            this._panelKelvin.TabIndex = 3;
            this._panelKelvin.TabStop = true;
            this._panelKelvin.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintKelvinPanel);
            // 
            // _lblKelvin
            // 
            this._lblKelvin.AutoSize = true;
            this._lblKelvin.BackColor = System.Drawing.Color.Transparent;
            this._lblKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblKelvin.ForeColor = System.Drawing.Color.White;
            this._lblKelvin.Location = new System.Drawing.Point(8, 110);
            this._lblKelvin.Name = "_lblKelvin";
            this._lblKelvin.Size = new System.Drawing.Size(14, 13);
            this._lblKelvin.TabIndex = 1;
            this._lblKelvin.Text = "K";
            // 
            // _lblCelcius
            // 
            this._lblCelcius.AutoSize = true;
            this._lblCelcius.BackColor = System.Drawing.Color.Transparent;
            this._lblCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCelcius.ForeColor = System.Drawing.Color.White;
            this._lblCelcius.Location = new System.Drawing.Point(8, 86);
            this._lblCelcius.Name = "_lblCelcius";
            this._lblCelcius.Size = new System.Drawing.Size(14, 13);
            this._lblCelcius.TabIndex = 1;
            this._lblCelcius.Text = "C";
            // 
            // _lblFarenheit
            // 
            this._lblFarenheit.AutoSize = true;
            this._lblFarenheit.BackColor = System.Drawing.Color.Transparent;
            this._lblFarenheit.Font = new System.Drawing.Font("Meiryo UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFarenheit.ForeColor = System.Drawing.Color.White;
            this._lblFarenheit.Location = new System.Drawing.Point(9, 62);
            this._lblFarenheit.Name = "_lblFarenheit";
            this._lblFarenheit.Size = new System.Drawing.Size(13, 13);
            this._lblFarenheit.TabIndex = 1;
            this._lblFarenheit.Text = "F";
            // 
            // _sliderBar
            // 
            this._sliderBar.Location = new System.Drawing.Point(8, 9);
            this._sliderBar.Name = "_sliderBar";
            this._sliderBar.Size = new System.Drawing.Size(293, 45);
            this._sliderBar.TabIndex = 1;
            this._sliderBar.Scroll += new System.EventHandler(this.OnTrackBarScrolling);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(312, 151);
            this.Controls.Add(this._lblSlideBarZeroTempValue);
            this.Controls.Add(this._lblSlideBarMaxTempValue);
            this.Controls.Add(this._lblSlideBarMinTempValue);
            this.Controls.Add(this._checkBoxRound);
            this.Controls.Add(this._lblRoundValues);
            this.Controls.Add(this._panelKelvin);
            this.Controls.Add(this._panelFahrenheit);
            this.Controls.Add(this._panelCelcius);
            this.Controls.Add(this._sliderBar);
            this.Controls.Add(this._lblCelciusValue);
            this.Controls.Add(this._lblKelvinValue);
            this.Controls.Add(this._lblFahrenheitValue);
            this.Controls.Add(this._lblKelvin);
            this.Controls.Add(this._lblCelcius);
            this.Controls.Add(this._lblFarenheit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 202);
            this.Name = "Form1";
            this.Text = "Temp+";
            ((System.ComponentModel.ISupportInitialize)(this._sliderBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblFahrenheitValue;
        private System.Windows.Forms.Label _lblKelvinValue;
        private System.Windows.Forms.Label _lblCelciusValue;
        private TempConverter.GUI.Components.NoFocusTrackBar _sliderBar;
        private System.Windows.Forms.Label _lblRoundValues;
        private System.Windows.Forms.CheckBox _checkBoxRound;
        private System.Windows.Forms.Label _lblSlideBarMinTempValue;
        private System.Windows.Forms.Label _lblSlideBarMaxTempValue;
        private System.Windows.Forms.Label _lblSlideBarZeroTempValue;
        private System.Windows.Forms.Panel _panelFahrenheit;
        private System.Windows.Forms.Panel _panelCelcius;
        private System.Windows.Forms.Panel _panelKelvin;
        private System.Windows.Forms.Label _lblKelvin;
        private System.Windows.Forms.Label _lblCelcius;
        private System.Windows.Forms.Label _lblFarenheit;
    }
}

