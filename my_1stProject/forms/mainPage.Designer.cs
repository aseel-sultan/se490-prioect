namespace my_1stProject.forms
{
    partial class mainPage
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
            this.Usetting = new System.Windows.Forms.Button();
            this.ItemSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usetting
            // 
            this.Usetting.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Usetting.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usetting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usetting.Location = new System.Drawing.Point(1054, 253);
            this.Usetting.Name = "Usetting";
            this.Usetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Usetting.Size = new System.Drawing.Size(313, 134);
            this.Usetting.TabIndex = 0;
            this.Usetting.Text = "اعدادات المستخدمين";
            this.Usetting.UseVisualStyleBackColor = false;
            this.Usetting.Click += new System.EventHandler(this.Usetting_Click);
            // 
            // ItemSetting
            // 
            this.ItemSetting.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ItemSetting.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemSetting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemSetting.Location = new System.Drawing.Point(540, 253);
            this.ItemSetting.Name = "ItemSetting";
            this.ItemSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemSetting.Size = new System.Drawing.Size(319, 134);
            this.ItemSetting.TabIndex = 0;
            this.ItemSetting.Text = "اعدادات اصناف البيع";
            this.ItemSetting.UseVisualStyleBackColor = false;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::my_1stProject.Properties.Resources.depositphotos_77833254_stock_illustration_restaurant_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1285, 594);
            this.Controls.Add(this.ItemSetting);
            this.Controls.Add(this.Usetting);
            this.Name = "mainPage";
            this.Text = "mainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Usetting;
        private System.Windows.Forms.Button ItemSetting;
    }
}