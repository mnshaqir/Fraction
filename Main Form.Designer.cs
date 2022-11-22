namespace Fraction
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
            if (disposing && (components != null))
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.DisplayValue = new System.Windows.Forms.CheckBox();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.PanelBar = new System.Windows.Forms.Panel();
            this.DenomiLabel = new System.Windows.Forms.Label();
            this.NumerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyDenomi = new System.Windows.Forms.Button();
            this.CopyNumer = new System.Windows.Forms.Button();
            this.DenomiTextBox = new System.Windows.Forms.TextBox();
            this.NumerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this._3DigRadioButton = new System.Windows.Forms.RadioButton();
            this._5DigRadioButton = new System.Windows.Forms.RadioButton();
            this._10DigRadioButton = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSystem);
            this.tabControl1.Controls.Add(this.tabControl);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSystem
            // 
            this.tabSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSystem.Location = new System.Drawing.Point(4, 22);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(788, 425);
            this.tabSystem.TabIndex = 0;
            this.tabSystem.Text = "System View";
            this.tabSystem.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControl.Controls.Add(this._10DigRadioButton);
            this.tabControl.Controls.Add(this._5DigRadioButton);
            this.tabControl.Controls.Add(this._3DigRadioButton);
            this.tabControl.Controls.Add(this.ValueLabel);
            this.tabControl.Controls.Add(this.DisplayValue);
            this.tabControl.Controls.Add(this.MsgLabel);
            this.tabControl.Controls.Add(this.PanelBar);
            this.tabControl.Controls.Add(this.DenomiLabel);
            this.tabControl.Controls.Add(this.NumerLabel);
            this.tabControl.Controls.Add(this.label1);
            this.tabControl.Controls.Add(this.CopyDenomi);
            this.tabControl.Controls.Add(this.CopyNumer);
            this.tabControl.Controls.Add(this.DenomiTextBox);
            this.tabControl.Controls.Add(this.NumerTextBox);
            this.tabControl.Controls.Add(this.label2);
            this.tabControl.Location = new System.Drawing.Point(4, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl.Size = new System.Drawing.Size(788, 425);
            this.tabControl.TabIndex = 1;
            this.tabControl.Text = "Web View";
            this.tabControl.UseVisualStyleBackColor = true;
            // 
            // DisplayValue
            // 
            this.DisplayValue.AutoSize = true;
            this.DisplayValue.Location = new System.Drawing.Point(85, 285);
            this.DisplayValue.Name = "DisplayValue";
            this.DisplayValue.Size = new System.Drawing.Size(90, 17);
            this.DisplayValue.TabIndex = 149;
            this.DisplayValue.Text = "Display Value";
            this.DisplayValue.UseVisualStyleBackColor = true;
            this.DisplayValue.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Location = new System.Drawing.Point(96, 241);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(50, 13);
            this.MsgLabel.TabIndex = 148;
            this.MsgLabel.Text = "Message";
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.Black;
            this.PanelBar.Location = new System.Drawing.Point(427, 131);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(98, 5);
            this.PanelBar.TabIndex = 147;
            // 
            // DenomiLabel
            // 
            this.DenomiLabel.AutoSize = true;
            this.DenomiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenomiLabel.Location = new System.Drawing.Point(449, 144);
            this.DenomiLabel.Name = "DenomiLabel";
            this.DenomiLabel.Size = new System.Drawing.Size(57, 63);
            this.DenomiLabel.TabIndex = 146;
            this.DenomiLabel.Text = "1";
            // 
            // NumerLabel
            // 
            this.NumerLabel.AutoSize = true;
            this.NumerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumerLabel.Location = new System.Drawing.Point(449, 60);
            this.NumerLabel.Name = "NumerLabel";
            this.NumerLabel.Size = new System.Drawing.Size(57, 63);
            this.NumerLabel.TabIndex = 145;
            this.NumerLabel.Text = "0";
            this.NumerLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numerator";
            // 
            // CopyDenomi
            // 
            this.CopyDenomi.Location = new System.Drawing.Point(309, 160);
            this.CopyDenomi.Name = "CopyDenomi";
            this.CopyDenomi.Size = new System.Drawing.Size(75, 23);
            this.CopyDenomi.TabIndex = 5;
            this.CopyDenomi.Text = ">>>";
            this.CopyDenomi.UseVisualStyleBackColor = true;
            this.CopyDenomi.Click += new System.EventHandler(this.CopyDenomi_Click);
            // 
            // CopyNumer
            // 
            this.CopyNumer.Location = new System.Drawing.Point(309, 81);
            this.CopyNumer.Name = "CopyNumer";
            this.CopyNumer.Size = new System.Drawing.Size(75, 23);
            this.CopyNumer.TabIndex = 4;
            this.CopyNumer.Text = ">>>";
            this.CopyNumer.UseVisualStyleBackColor = true;
            this.CopyNumer.Click += new System.EventHandler(this.CopyNumer_Click);
            // 
            // DenomiTextBox
            // 
            this.DenomiTextBox.Location = new System.Drawing.Point(177, 160);
            this.DenomiTextBox.Name = "DenomiTextBox";
            this.DenomiTextBox.Size = new System.Drawing.Size(100, 20);
            this.DenomiTextBox.TabIndex = 3;
            // 
            // NumerTextBox
            // 
            this.NumerTextBox.Location = new System.Drawing.Point(177, 84);
            this.NumerTextBox.Name = "NumerTextBox";
            this.NumerTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Denominator";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(182, 285);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueLabel.TabIndex = 150;
            this.ValueLabel.Text = "--";
            // 
            // _3DigRadioButton
            // 
            this._3DigRadioButton.AutoSize = true;
            this._3DigRadioButton.Location = new System.Drawing.Point(85, 326);
            this._3DigRadioButton.Name = "_3DigRadioButton";
            this._3DigRadioButton.Size = new System.Drawing.Size(99, 17);
            this._3DigRadioButton.TabIndex = 151;
            this._3DigRadioButton.TabStop = true;
            this._3DigRadioButton.Text = "3 Decimal Point";
            this._3DigRadioButton.UseVisualStyleBackColor = true;
            // 
            // _5DigRadioButton
            // 
            this._5DigRadioButton.AutoSize = true;
            this._5DigRadioButton.Location = new System.Drawing.Point(232, 326);
            this._5DigRadioButton.Name = "_5DigRadioButton";
            this._5DigRadioButton.Size = new System.Drawing.Size(99, 17);
            this._5DigRadioButton.TabIndex = 152;
            this._5DigRadioButton.TabStop = true;
            this._5DigRadioButton.Text = "5 Decimal Point";
            this._5DigRadioButton.UseVisualStyleBackColor = true;
            // 
            // _10DigRadioButton
            // 
            this._10DigRadioButton.AutoSize = true;
            this._10DigRadioButton.Location = new System.Drawing.Point(379, 326);
            this._10DigRadioButton.Name = "_10DigRadioButton";
            this._10DigRadioButton.Size = new System.Drawing.Size(105, 17);
            this._10DigRadioButton.TabIndex = 153;
            this._10DigRadioButton.TabStop = true;
            this._10DigRadioButton.Text = "10 Decimal Point";
            this._10DigRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Fraction";
            this.tabControl1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.TextBox DenomiTextBox;
        private System.Windows.Forms.TextBox NumerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CopyDenomi;
        private System.Windows.Forms.Button CopyNumer;
        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Label DenomiLabel;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.CheckBox DisplayValue;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.RadioButton _10DigRadioButton;
        private System.Windows.Forms.RadioButton _5DigRadioButton;
        private System.Windows.Forms.RadioButton _3DigRadioButton;
    }
}

