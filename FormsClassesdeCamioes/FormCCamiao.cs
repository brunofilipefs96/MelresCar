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
    public partial class FormCCamiao : Form
    {
        public FormCCamiao()
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
            gridCamiaoC.Columns.Add("Matrícula", "Matrícula");
            gridCamiaoC.Columns.Add("Marca", "Marca");
            gridCamiaoC.Columns.Add("Modelo", "Modelo");
            gridCamiaoC.Columns.Add("Estado", "Estado");
            gridCamiaoC.Columns.Add("Combustível", "Combustível");
            gridCamiaoC.Columns.Add("PesoMáximo", "PesoMáximo");
            gridCamiaoC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCamiaoC.EnableHeadersVisualStyles = false;
            gridCamiaoC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoC.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCamiaoC.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoC.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamiaoC.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamiaoC.RowsDefaultCellStyle.ForeColor = Color.White;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridCamiaoC.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Camiao)
                    {
                        Camiao camiao = (Camiao)veiculo;

                        if (camiao.ClasseVeiculo == "C")
                        {
                            gridCamiaoC.Rows.Add(camiao.Matricula, camiao.Marca, camiao.Modelo, camiao.Estado, camiao.Combustivel, camiao.PesoMaximo, camiao.PrecoDiario);
                        }
                    }
                }
            }
        }

        private void crownButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
