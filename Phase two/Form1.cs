using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIpAddress.Text; 
            Ping pingSender = new Ping(); 
            try
            {
               
                PingReply reply = pingSender.Send(ipAddress);
                if (reply.Status == IPStatus.Success)
                {
                    lblResult.Text = $"Résultat : Ping à {ipAddress} réussi, temps de réponse : {reply.RoundtripTime} ms";
                }
                else
                {
                    lblResult.Text = $"Résultat : Ping à {ipAddress} échoué.";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Erreur : {ex.Message}"; 
            }
        }
    }
}
