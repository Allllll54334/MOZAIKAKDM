namespace mosaic
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoadPicture = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMixed = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRestore = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadPicture,
            this.toolStripButtonMixed,
            this.toolStripButtonRestore,
            this.toolStripButtonSetting,
            this.toolStripButtonHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLoadPicture
            // 
            this.toolStripButtonLoadPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadPicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadPicture.Name = "toolStripButtonLoadPicture";
            this.toolStripButtonLoadPicture.Size = new System.Drawing.Size(78, 24);
            this.toolStripButtonLoadPicture.Text = "Картинка";
            this.toolStripButtonLoadPicture.Click += new System.EventHandler(this.ToolStripButtonLoadPicture_Click);
            // 
            // toolStripButtonMixed
            // 
            this.toolStripButtonMixed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMixed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMixed.Name = "toolStripButtonMixed";
            this.toolStripButtonMixed.Size = new System.Drawing.Size(102, 24);
            this.toolStripButtonMixed.Text = "Перемешать";
            this.toolStripButtonMixed.Click += new System.EventHandler(this.ToolStripButtonMixed_Click);
            // 
            // toolStripButtonRestore
            // 
            this.toolStripButtonRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRestore.Name = "toolStripButtonRestore";
            this.toolStripButtonRestore.Size = new System.Drawing.Size(108, 24);
            this.toolStripButtonRestore.Text = "Восстановить";
            this.toolStripButtonRestore.Click += new System.EventHandler(this.ToolStripButtonRestore_Click);
            // 
            // toolStripButtonSetting
            // 
            this.toolStripButtonSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetting.Name = "toolStripButtonSetting";
            this.toolStripButtonSetting.Size = new System.Drawing.Size(88, 24);
            this.toolStripButtonSetting.Text = "Настройки";
            this.toolStripButtonSetting.Click += new System.EventHandler(this.ToolStripButtonSetting_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHelp.Image")));
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(73, 24);
            this.toolStripButtonHelp.Text = "Помощь";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.ToolStripButtonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(853, 622);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Мозаика";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadPicture;
        private System.Windows.Forms.ToolStripButton toolStripButtonMixed;
        private System.Windows.Forms.ToolStripButton toolStripButtonRestore;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetting;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;





    }
}

