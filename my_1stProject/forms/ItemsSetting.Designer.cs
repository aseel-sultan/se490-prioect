namespace DepartmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.Black;
            this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.Location = new System.Drawing.Point(505, 90);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(200, 70);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "الأصناف";
            this.btnItem.UseVisualStyleBackColor = false;
            // 
            // btnDeps
            // 
            this.btnDeps.BackColor = System.Drawing.Color.Black;
            this.btnDeps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeps.ForeColor = System.Drawing.Color.White;
            this.btnDeps.Location = new System.Drawing.Point(88, 90);
            this.btnDeps.Name = "btnDeps";
            this.btnDeps.Size = new System.Drawing.Size(200, 70);
            this.btnDeps.TabIndex = 2;
            this.btnDeps.Text = "الأقسام";
            this.btnDeps.UseVisualStyleBackColor = false;
            this.btnDeps.Click += new System.EventHandler(this.btnDeps_Click);
            // 
            // lblItemsetting
            // 
            this.lblItemsetting.AutoSize = true;
            this.lblItemsetting.BackColor = System.Drawing.Color.Transparent;
            this.lblItemsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsetting.Location = new System.Drawing.Point(308, 37);
            this.lblItemsetting.Name = "lblItemsetting";
            this.lblItemsetting.Size = new System.Drawing.Size(183, 31);
            this.lblItemsetting.TabIndex = 3;
            this.lblItemsetting.Text = "إعدادات الأصناف";
            this.lblItemsetting.Click += new System.EventHandler(this.lblItemsetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "رجوع";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemsSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItemsetting);
            this.Controls.Add(this.btnDeps);
            this.Controls.Add(this.btnItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Label label1;
    }
}