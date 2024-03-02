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
    public partial class FormBCamioneta : Form
    {
        public FormBCamioneta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridCamionetaB.Columns.Add("Matrícula", "Matrícula");
            gridCamionetaB.Columns.Add("Marca", "Marca");
            gridCamionetaB.Columns.Add("Modelo", "Modelo");
            gridCamionetaB.Columns.Add("Estado", "Estado");
            gridCamionetaB.Columns.Add("Combustível", "Combustível");
            gridCamionetaB.Columns.Add("NumEixos", "NumEixos");
            gridCamionetaB.Columns.Add("NumPassageiros", "NumPassageiros");
            gridCamionetaB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridCamionetaB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridCamionetaB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCamionetaB.MultiSelect = false;
            gridCamionetaB.EnableHeadersVisualStyles = false;
            gridCamionetaB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridCamionetaB.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaB.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaB.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridCamionetaB.RowsDefaultCellStyle.ForeColor = Color.White;
            gridCamionetaB.ScrollBars = ScrollBars.Vertical;

        }

        private void atualizaDataGridView()
        {
            gridCamionetaB.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Camioneta)
                {
                    Camioneta camioneta = (Camioneta)veiculo;

                    if (camioneta.ClasseVeiculo == "B")
                    {
                        gridCamionetaB.Rows.Add(camioneta.Matricula, camioneta.Marca, camioneta.Modelo, camioneta.Estado, camioneta.Combustivel, camioneta.NumEixos, camioneta.NumPassageiros, camioneta.PrecoDiario);
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
