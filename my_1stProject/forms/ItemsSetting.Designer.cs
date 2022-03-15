namespace my_1stProject.forms
{
    partial class ItemsSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsSetting));
            this.btnItem = new System.Windows.Forms.Button();
            this.btnDeps = new System.Windows.Forms.Button();
            this.lblItemsetting = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.Black;
            this.btnItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.Location = new System.Drawing.Point(1290, 154);
            this.btnItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(320, 134);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "الأصناف";
            this.btnItem.UseVisualStyleBackColor = false;
            // 
            // btnDeps
            // 
            this.btnDeps.BackColor = System.Drawing.Color.Black;
            this.btnDeps.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeps.ForeColor = System.Drawing.Color.White;
            this.btnDeps.Location = new System.Drawing.Point(292, 154);
            this.btnDeps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeps.Name = "btnDeps";
            this.btnDeps.Size = new System.Drawing.Size(320, 134);
            this.btnDeps.TabIndex = 2;
            this.btnDeps.Text = "الأقسام";
            this.btnDeps.UseVisualStyleBackColor = false;
            this.btnDeps.Click += new System.EventHandler(this.btnDeps_Click);
            // 
            // lblItemsetting
            // 
            this.lblItemsetting.AutoSize = true;
            this.lblItemsetting.BackColor = System.Drawing.Color.Transparent;
            this.lblItemsetting.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsetting.Location = new System.Drawing.Point(813, 66);
            this.lblItemsetting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsetting.Name = "lblItemsetting";
            this.lblItemsetting.Size = new System.Drawing.Size(285, 55);
            this.lblItemsetting.TabIndex = 3;
            this.lblItemsetting.Text = "إعدادات الأصناف";
            this.lblItemsetting.Click += new System.EventHandler(this.lblItemsetting_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(292, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 88);
            this.button3.TabIndex = 8;
            this.button3.Text = "رجوع";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ItemsSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblItemsetting);
            this.Controls.Add(this.btnDeps);
            this.Controls.Add(this.btnItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemsSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepForm";
            this.Load += new System.EventHandler(this.DepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DepForm_Load(object sender, System.EventArgs e)
        {
           // throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnDeps;
        private System.Windows.Forms.Label lblItemsetting;
        private System.Windows.Forms.Button button3;
    }
}