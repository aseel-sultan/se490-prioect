namespace DepartmentForm.UI
{
    partial class MessageFuns
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
            this.lblDepname = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepname
            // 
            this.lblDepname.AutoSize = true;
            this.lblDepname.BackColor = System.Drawing.Color.Transparent;
            this.lblDepname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepname.Location = new System.Drawing.Point(132, 138);
            this.lblDepname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepname.Name = "lblDepname";
            this.lblDepname.Size = new System.Drawing.Size(160, 29);
            this.lblDepname.TabIndex = 6;
            this.lblDepname.Text = "تمت الإضافة بنجاح";
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Black;
            this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.Color.White;
            this.btnExist.Location = new System.Drawing.Point(174, 194);
            this.btnExist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(87, 45);
            this.btnExist.TabIndex = 7;
            this.btnExist.Text = "خروج";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // MessageFuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 402);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.lblDepname);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MessageFuns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رسالة تأكيد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepname;
        private System.Windows.Forms.Button btnExist;
    }
}