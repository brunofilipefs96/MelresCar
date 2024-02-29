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
    public partial class FormBMota : Form
    {
        public FormBMota()
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
            gridMotaB.Columns.Add("Matrícula", "Matrícula");
            gridMotaB.Columns.Add("Marca", "Marca");
            gridMotaB.Columns.Add("Modelo", "Modelo");
            gridMotaB.Columns.Add("Estado", "Estado");
            gridMotaB.Columns.Add("Combustível", "Combustível");
            gridMotaB.Columns.Add("Cilindrada", "Cilindrada"); 
            gridMotaB.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridMotaB.EnableHeadersVisualStyles = false;
            gridMotaB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridMotaB.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaB.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaB.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaB.RowsDefaultCellStyle.ForeColor = Color.White;
            gridMotaB.ScrollBars = ScrollBars.Vertical;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridMotaB.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Mota)
                    {
                        Mota mota = (Mota)veiculo;

                        if (mota.ClasseVeiculo == "B")
                        {
                            gridMotaB.Rows.Add(mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
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
