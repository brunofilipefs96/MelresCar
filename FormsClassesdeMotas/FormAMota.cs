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
    public partial class FormAMota : Form
    {
        public FormAMota()
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
            gridMotaA.Columns.Add("Matrícula", "Matrícula");
            gridMotaA.Columns.Add("Marca", "Marca");
            gridMotaA.Columns.Add("Modelo", "Modelo");
            gridMotaA.Columns.Add("Estado", "Estado");
            gridMotaA.Columns.Add("Combustível", "Combustível");
            gridMotaA.Columns.Add("Cilindrada", "Cilindrada");
            gridMotaA.Columns.Add("PreçoDiário", "PreçoDiário");

            //configurações do datagridview
            gridMotaA.EnableHeadersVisualStyles = false;
            gridMotaA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaA.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            gridMotaA.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaA.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            gridMotaA.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            gridMotaA.RowsDefaultCellStyle.ForeColor = Color.White;
            gridMotaA.ScrollBars = ScrollBars.Vertical;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!IsDisposed && !Disposing)  //controla se o datagridview foi eliminado se sim não faz nada(problemas no logout)
            {
                gridMotaA.Rows.Clear();
                foreach (var veiculo in Program.melresCar.Veiculos)
                {
                    if (veiculo is Mota)
                    {
                        Mota mota = (Mota)veiculo;

                        if (mota.ClasseVeiculo == "A")
                        {
                            gridMotaA.Rows.Add(mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
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
