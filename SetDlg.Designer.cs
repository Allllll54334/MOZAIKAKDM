namespace mosaic
{
    partial class SetDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_5x5 = new System.Windows.Forms.RadioButton();
            this.radioButton_4x4 = new System.Windows.Forms.RadioButton();
            this.radioButton_3x3 = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_5x5);
            this.groupBox1.Controls.Add(this.radioButton_4x4);
            this.groupBox1.Controls.Add(this.radioButton_3x3);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(328, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сложность";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество прямоугольников по вертикали и горизонтали";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton_5x5
            // 
            this.radioButton_5x5.AutoSize = true;
            this.radioButton_5x5.Location = new System.Drawing.Point(241, 76);
            this.radioButton_5x5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_5x5.Name = "radioButton_5x5";
            this.radioButton_5x5.Size = new System.Drawing.Size(59, 21);
            this.radioButton_5x5.TabIndex = 0;
            this.radioButton_5x5.TabStop = true;
            this.radioButton_5x5.Text = "5 x 5";
            this.radioButton_5x5.UseVisualStyleBackColor = true;
            this.radioButton_5x5.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_4x4
            // 
            this.radioButton_4x4.AutoSize = true;
            this.radioButton_4x4.Location = new System.Drawing.Point(241, 48);
            this.radioButton_4x4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_4x4.Name = "radioButton_4x4";
            this.radioButton_4x4.Size = new System.Drawing.Size(59, 21);
            this.radioButton_4x4.TabIndex = 0;
            this.radioButton_4x4.TabStop = true;
            this.radioButton_4x4.Text = "4 x 4";
            this.radioButton_4x4.UseVisualStyleBackColor = true;
            this.radioButton_4x4.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // radioButton_3x3
            // 
            this.radioButton_3x3.AutoSize = true;
            this.radioButton_3x3.Location = new System.Drawing.Point(241, 20);
            this.radioButton_3x3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_3x3.Name = "radioButton_3x3";
            this.radioButton_3x3.Size = new System.Drawing.Size(59, 21);
            this.radioButton_3x3.TabIndex = 0;
            this.radioButton_3x3.TabStop = true;
            this.radioButton_3x3.Text = "3 x 3";
            this.radioButton_3x3.UseVisualStyleBackColor = true;
            this.radioButton_3x3.CheckedChanged += new System.EventHandler(this.radioButton_3x3_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(63, 144);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(188, 144);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SetDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 192);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SetDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SetDlg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButton_5x5;
        private System.Windows.Forms.RadioButton radioButton_4x4;
        private System.Windows.Forms.RadioButton radioButton_3x3;
        private System.Windows.Forms.Label label1;
    }
}