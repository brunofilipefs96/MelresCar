using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormCCamioneta : Form
    {
        public FormCCamioneta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            Dock = DockStyle.Fill;
            gridCamionetaC.Columns.Add("Matrícula", "Matrícula");
            gridCamionetaC.Columns.Add("Marca", "Marca");
            gridCamionetaC.Columns.Add("Modelo", "Modelo");
            gridCamionetaC.Columns.Add("Estado", "Estado");
            gridCamionetaC.Columns.Add("Combustível", "Combustível");
            gridCamionetaC.Columns.Add("NumEixos", "NumEixos");
            gridCamionetaC.Columns.Add("NumPassageiros", "NumPassageiros");
            gridCamionetaC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCamionetaC.EnableHeadersVisualStyles = false;
            gridCamionetaC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaC.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCamionetaC.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaC.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaC.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaC.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaC.ScrollBars = ScrollBars.Vertical;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridCamionetaC.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Camioneta)
                    {
                        Camioneta camioneta = (Camioneta)veiculo;

                        if (camioneta.ClasseVeiculo == "C")
                        {
                            gridCamionetaC.Rows.Add(camioneta.Matricula, camioneta.Marca, camioneta.Modelo, camioneta.Estado, camioneta.Combustivel, camioneta.NumEixos, camioneta.NumPassageiros, camioneta.PrecoDiario);
                        }
                    }
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
