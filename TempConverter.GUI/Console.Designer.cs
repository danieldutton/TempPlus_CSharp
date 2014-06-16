
using TempConverter.GUI.Components;
using TempConverter.Model.Domain;

namespace TempConverter.GUI
{
    partial class Console
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Console));
            this._lblFahrenheitValue = new System.Windows.Forms.Label();
            this._lblKelvinValue = new System.Windows.Forms.Label();
            this._lblCelsiusValue = new System.Windows.Forms.Label();
            this._lblRound = new System.Windows.Forms.Label();
            this._checkBoxRound = new System.Windows.Forms.CheckBox();
            this._lblMinTemp = new System.Windows.Forms.Label();
            this._lblMaxTemp = new System.Windows.Forms.Label();
            this._lblZero = new System.Windows.Forms.Label();
            this._panelFahrenheit = new System.Windows.Forms.Panel();
            this._panelCelcius = new System.Windows.Forms.Panel();
            this._panelKelvin = new System.Windows.Forms.Panel();
            this._lblKelvin = new System.Windows.Forms.Label();
            this._lblCelsius = new System.Windows.Forms.Label();
            this._lblFahrenheit = new System.Windows.Forms.Label();
            this._sliderBar = new NoFocusTrackBar(new Scale<int>(-150, 150, 3));
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
            // _lblCelsiusValue
            // 
            this._lblCelsiusValue.AutoSize = true;
            this._lblCelsiusValue.BackColor = System.Drawing.Color.Transparent;
            this._lblCelsiusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCelsiusValue.ForeColor = System.Drawing.Color.White;
            this._lblCelsiusValue.Location = new System.Drawing.Point(149, 86);
            this._lblCelsiusValue.Name = "_lblCelsiusValue";
            this._lblCelsiusValue.Size = new System.Drawing.Size(13, 13);
            this._lblCelsiusValue.TabIndex = 1;
            this._lblCelsiusValue.Text = "0";
            // 
            // _lblRound
            // 
            this._lblRound.AutoSize = true;
            this._lblRound.Font = new System.Drawing.Font("Rod", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRound.ForeColor = System.Drawing.Color.White;
            this._lblRound.Location = new System.Drawing.Point(8, 132);
            this._lblRound.Name = "_lblRound";
            this._lblRound.Size = new System.Drawing.Size(38, 14);
            this._lblRound.TabIndex = 4;
            this._lblRound.Text = "Round";
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
            // _lblMinTemp
            // 
            this._lblMinTemp.AutoSize = true;
            this._lblMinTemp.Font = new System.Drawing.Font("Trebuchet MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMinTemp.ForeColor = System.Drawing.Color.Red;
            this._lblMinTemp.Location = new System.Drawing.Point(9, 44);
            this._lblMinTemp.Name = "_lblMinTemp";
            this._lblMinTemp.Size = new System.Drawing.Size(25, 15);
            this._lblMinTemp.TabIndex = 6;
            this._lblMinTemp.Text = "-150";
            // 
            // _lblMaxTemp
            // 
            this._lblMaxTemp.AutoSize = true;
            this._lblMaxTemp.Font = new System.Drawing.Font("Trebuchet MS", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMaxTemp.ForeColor = System.Drawing.Color.Yellow;
            this._lblMaxTemp.Location = new System.Drawing.Point(278, 44);
            this._lblMaxTemp.Name = "_lblMaxTemp";
            this._lblMaxTemp.Size = new System.Drawing.Size(22, 15);
            this._lblMaxTemp.TabIndex = 7;
            this._lblMaxTemp.Text = "150";
            // 
            // _lblZero
            // 
            this._lblZero.AutoSize = true;
            this._lblZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblZero.ForeColor = System.Drawing.Color.RoyalBlue;
            this._lblZero.Location = new System.Drawing.Point(150, 45);
            this._lblZero.Name = "_lblZero";
            this._lblZero.Size = new System.Drawing.Size(10, 12);
            this._lblZero.TabIndex = 7;
            this._lblZero.Text = "0";
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
            // _lblCelsius
            // 
            this._lblCelsius.AutoSize = true;
            this._lblCelsius.BackColor = System.Drawing.Color.Transparent;
            this._lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCelsius.ForeColor = System.Drawing.Color.White;
            this._lblCelsius.Location = new System.Drawing.Point(8, 86);
            this._lblCelsius.Name = "_lblCelsius";
            this._lblCelsius.Size = new System.Drawing.Size(14, 13);
            this._lblCelsius.TabIndex = 1;
            this._lblCelsius.Text = "C";
            // 
            // _lblFahrenheit
            // 
            this._lblFahrenheit.AutoSize = true;
            this._lblFahrenheit.BackColor = System.Drawing.Color.Transparent;
            this._lblFahrenheit.Font = new System.Drawing.Font("Meiryo UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFahrenheit.ForeColor = System.Drawing.Color.White;
            this._lblFahrenheit.Location = new System.Drawing.Point(9, 62);
            this._lblFahrenheit.Name = "_lblFahrenheit";
            this._lblFahrenheit.Size = new System.Drawing.Size(13, 13);
            this._lblFahrenheit.TabIndex = 1;
            this._lblFahrenheit.Text = "F";
            // 
            // _sliderBar
            // 
            this._sliderBar.Location = new System.Drawing.Point(8, 9);
            this._sliderBar.Maximum = 150;
            this._sliderBar.Minimum = -150;
            this._sliderBar.Name = "_sliderBar";
            this._sliderBar.Size = new System.Drawing.Size(293, 45);
            this._sliderBar.TabIndex = 1;
            this._sliderBar.TickFrequency = 10;
            this._sliderBar.Scroll += new System.EventHandler(this.OnTrackBarScroll);
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(312, 151);
            this.Controls.Add(this._lblZero);
            this.Controls.Add(this._lblMaxTemp);
            this.Controls.Add(this._lblMinTemp);
            this.Controls.Add(this._checkBoxRound);
            this.Controls.Add(this._lblRound);
            this.Controls.Add(this._panelKelvin);
            this.Controls.Add(this._panelFahrenheit);
            this.Controls.Add(this._panelCelcius);
            this.Controls.Add(this._sliderBar);
            this.Controls.Add(this._lblCelsiusValue);
            this.Controls.Add(this._lblKelvinValue);
            this.Controls.Add(this._lblFahrenheitValue);
            this.Controls.Add(this._lblKelvin);
            this.Controls.Add(this._lblCelsius);
            this.Controls.Add(this._lblFahrenheit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 202);
            this.Name = "Console";
            this.Text = "Temp+";
            ((System.ComponentModel.ISupportInitialize)(this._sliderBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblFahrenheitValue;
        private System.Windows.Forms.Label _lblKelvinValue;
        private System.Windows.Forms.Label _lblCelsiusValue;
        private TempConverter.GUI.Components.NoFocusTrackBar _sliderBar;
        private System.Windows.Forms.Label _lblRound;
        private System.Windows.Forms.CheckBox _checkBoxRound;
        private System.Windows.Forms.Label _lblMinTemp;
        private System.Windows.Forms.Label _lblMaxTemp;
        private System.Windows.Forms.Label _lblZero;
        private System.Windows.Forms.Panel _panelFahrenheit;
        private System.Windows.Forms.Panel _panelCelcius;
        private System.Windows.Forms.Panel _panelKelvin;
        private System.Windows.Forms.Label _lblKelvin;
        private System.Windows.Forms.Label _lblCelsius;
        private System.Windows.Forms.Label _lblFahrenheit;
    }
}

