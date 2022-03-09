namespace DepartmentForm.UI
{
    partial class AddDep
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
            this.txtDepNa = new System.Windows.Forms.TextBox();
            this.btnFun = new System.Windows.Forms.Button();
            this.lblDepname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDepNa
            // 
            this.txtDepNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepNa.Location = new System.Drawing.Point(87, 119);
            this.txtDepNa.Name = "txtDepNa";
            this.txtDepNa.Size = new System.Drawing.Size(201, 26);
            this.txtDepNa.TabIndex = 0;
            // 
            // btnFun
            // 
            this.btnFun.BackColor = System.Drawing.Color.Black;
            this.btnFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFun.ForeColor = System.Drawing.Color.White;
            this.btnFun.Location = new System.Drawing.Point(231, 167);
            this.btnFun.Name = "btnFun";
            this.btnFun.Size = new System.Drawing.Size(57, 25);
            this.btnFun.TabIndex = 2;
            this.btnFun.Text = "إضافة";
            this.btnFun.UseVisualStyleBackColor = false;
            this.btnFun.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // lblDepname
            // 
            this.lblDepname.AutoSize = true;
            this.lblDepname.BackColor = System.Drawing.Color.Transparent;
            this.lblDepname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepname.Location = new System.Drawing.Point(202, 72);
            this.lblDepname.Name = "lblDepname";
            this.lblDepname.Size = new System.Drawing.Size(95, 25);
            this.lblDepname.TabIndex = 5;
            this.lblDepname.Text = ":اسم القسم";
            this.lblDepname.Click += new System.EventHandler(this.lblDepname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "رجوع";
            // 
            // AddDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDepname);
            this.Controls.Add(this.btnFun);
            this.Controls.Add(this.txtDepNa);
            this.Name = "AddDep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepNa;
        private System.Windows.Forms.Button btnFun;
        private System.Windows.Forms.Label lblDepname;
        private System.Windows.Forms.Label label1;
    }
}