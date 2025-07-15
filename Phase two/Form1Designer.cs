namespace PingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

          
            this.txtIpAddress.Location = new System.Drawing.Point(12, 12);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(200, 20);
            this.txtIpAddress.TabIndex = 0;

          
            this.btnPing.Location = new System.Drawing.Point(12, 38);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 1;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);

           
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 64);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Résultat : ";

           
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.txtIpAddress);
            this.Name = "Form1";
            this.Text = "Ping App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label lblResult;
    }
}
