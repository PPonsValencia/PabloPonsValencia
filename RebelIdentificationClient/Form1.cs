using System;
using System.Windows.Forms;

namespace RebelIdentificationClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Refresh();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            using (RebelIdentificationWebService.WebService1SoapClient ws = new RebelIdentificationWebService.WebService1SoapClient())
            {
                if (rebelNameAdd.Text.Length > 0 && planetNameAdd.Text.Length > 0)
                {
                    if (ws.RebelSighting(rebelNameAdd.Text, planetNameAdd.Text))
                    {
                        rebelNameAdd.Text = string.Empty;
                        planetNameAdd.Text = string.Empty;
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("El servicio web no ha sido capaz de almacenar el dato. Inténtelo en un rato.");
                    }
                }
                else
                {
                    MessageBox.Show("Completa los campos de 'Nombre de rebelde' y 'Nombre de planeta'.");
                }
            }
        }

        private void Refresh()
        {
            using (RebelIdentificationWebService.WebService1SoapClient ws = new RebelIdentificationWebService.WebService1SoapClient())
            {
                var lines = ws.ReadAll();
                rebelList.Items.Clear();
                rebelList.Items.AddRange(lines.ToArray());
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            using (RebelIdentificationWebService.WebService1SoapClient ws = new RebelIdentificationWebService.WebService1SoapClient())
            {
                var lines = ws.ReadByName(rebelNameSearch.Text);
                rebelList.Items.Clear();
                rebelList.Items.AddRange(lines.ToArray());
            }

        }
    }
}
