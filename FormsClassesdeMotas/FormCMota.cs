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
    public partial class FormCMota : Form
    {
        public FormCMota()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.Fill;
            gridMotaC.Columns.Add("Matrícula", "Matrícula");
            gridMotaC.Columns.Add("Marca", "Marca");
            gridMotaC.Columns.Add("Modelo", "Modelo");
            gridMotaC.Columns.Add("Estado", "Estado");
            gridMotaC.Columns.Add("Combustível", "Combustível");
            gridMotaC.Columns.Add("Cilindrada", "Cilindrada");
            gridMotaC.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridMotaC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridMotaC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMotaC.MultiSelect = false;
            gridMotaC.EnableHeadersVisualStyles = false;
            gridMotaC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaC.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridMotaC.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaC.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaC.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaC.RowsDefaultCellStyle.ForeColor = Color.White;
            gridMotaC.ScrollBars = ScrollBars.Vertical;

            atualizaDataGridView();
        }

        private void atualizaDataGridView()
        {
            gridMotaC.Rows.Clear();
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (veiculo is Mota)
                {
                    Mota mota = (Mota)veiculo;

                    if (mota.ClasseVeiculo == "C")
                    {
                        gridMotaC.Rows.Add(mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
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
