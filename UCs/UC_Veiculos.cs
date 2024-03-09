using Automobile.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class UC_Veiculos : UserControl
    {
        public UC_Veiculos()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridViewVeiculos.AllowUserToAddRows = false;
            dataGridViewVeiculos.RowCount = 0;
            dataGridViewVeiculos.Columns.Add("NumCliente", "NumCliente");
            dataGridViewVeiculos.Columns.Add("Nome", "Nome");
            dataGridViewVeiculos.Columns.Add("Nif", "NIF");
            dataGridViewVeiculos.Columns.Add("Morada", "Morada");
            dataGridViewVeiculos.Columns.Add("Email", "Email");
            dataGridViewVeiculos.Columns.Add("Telemovel", "Telemovel");


            dataGridViewVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVeiculos.MultiSelect = false;

            dataGridViewVeiculos.EnableHeadersVisualStyles = false;
            dataGridViewVeiculos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewVeiculos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewVeiculos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewVeiculos.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewVeiculos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewVeiculos.RowsDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            dataGridViewVeiculos.RowsDefaultCellStyle.ForeColor = Color.White;

            atualizaDataGridView(comboBoxTipoVeiculo.SelectedIndex);
        }

        public void atualizaDataGridView(int index)
        {
            comboBoxTipoVeiculo.SelectedIndex = index;
            dataGridViewVeiculos.Columns.Clear();
            dataGridViewVeiculos.Rows.Clear();
            if (comboBoxTipoVeiculo.SelectedIndex == 0)
            {
                dataGridViewVeiculos.Columns.Add("ID", "ID");
                dataGridViewVeiculos.Columns.Add("Matrícula", "Matrícula");
                dataGridViewVeiculos.Columns.Add("Marca", "Marca");
                dataGridViewVeiculos.Columns.Add("Modelo", "Modelo");
                dataGridViewVeiculos.Columns.Add("Estado", "Estado");
                dataGridViewVeiculos.Columns.Add("Combustível", "Combustível");
                dataGridViewVeiculos.Columns.Add("NumPortas", "NumPortas");
                dataGridViewVeiculos.Columns.Add("TipoCaixa", "TipoCaixa");
                dataGridViewVeiculos.Columns.Add("PreçoDiário", "PreçoDiário");
            }
            else if (comboBoxTipoVeiculo.SelectedIndex == 1)
            {
                dataGridViewVeiculos.Columns.Add("ID", "ID");
                dataGridViewVeiculos.Columns.Add("Matrícula", "Matrícula");
                dataGridViewVeiculos.Columns.Add("Marca", "Marca");
                dataGridViewVeiculos.Columns.Add("Modelo", "Modelo");
                dataGridViewVeiculos.Columns.Add("Estado", "Estado");
                dataGridViewVeiculos.Columns.Add("Combustível", "Combustível");
                dataGridViewVeiculos.Columns.Add("Cilindrada", "Cilindrada");
                dataGridViewVeiculos.Columns.Add("PreçoDiário", "PreçoDiário");
            }
            else if (comboBoxTipoVeiculo.SelectedIndex == 2)
            {
                dataGridViewVeiculos.Columns.Add("ID", "ID");
                dataGridViewVeiculos.Columns.Add("Matrícula", "Matrícula");
                dataGridViewVeiculos.Columns.Add("Marca", "Marca");
                dataGridViewVeiculos.Columns.Add("Modelo", "Modelo");
                dataGridViewVeiculos.Columns.Add("Estado", "Estado");
                dataGridViewVeiculos.Columns.Add("Combustível", "Combustível");
                dataGridViewVeiculos.Columns.Add("NumEixos", "NumEixos");
                dataGridViewVeiculos.Columns.Add("NumPassageiros", "NumPassageiros");
                dataGridViewVeiculos.Columns.Add("PreçoDiário", "PreçoDiário");
            }
            else if (comboBoxTipoVeiculo.SelectedIndex == 3)
            {
                dataGridViewVeiculos.Columns.Add("ID", "ID");
                dataGridViewVeiculos.Columns.Add("Matrícula", "Matrícula");
                dataGridViewVeiculos.Columns.Add("Marca", "Marca");
                dataGridViewVeiculos.Columns.Add("Modelo", "Modelo");
                dataGridViewVeiculos.Columns.Add("Estado", "Estado");
                dataGridViewVeiculos.Columns.Add("Combustível", "Combustível");
                dataGridViewVeiculos.Columns.Add("PesoMáximo", "PesoMáximo");
                dataGridViewVeiculos.Columns.Add("PreçoDiário", "PreçoDiário");
            }
            foreach (var veiculo in Program.melresCar.Veiculos)
            {
                if (comboBoxTipoVeiculo.SelectedIndex == 0)
                {
                    if (veiculo is Carro)
                    {
                        Carro carro = (Carro)veiculo;
                        dataGridViewVeiculos.Rows.Add(veiculo.IdVeiculo, carro.Matricula, carro.Marca, carro.Modelo, carro.Estado, carro.Combustivel, carro.NumPortas, carro.TipoCaixa, carro.PrecoDiario);
                    }
                }
                else if (comboBoxTipoVeiculo.SelectedIndex == 1)
                {
                    if (veiculo is Mota)
                    {
                        Mota mota = (Mota)veiculo;
                        dataGridViewVeiculos.Rows.Add(veiculo.IdVeiculo, mota.Matricula, mota.Marca, mota.Modelo, mota.Estado, mota.Combustivel, mota.Cilindrada, mota.PrecoDiario);
                    }
                }
                else if (comboBoxTipoVeiculo.SelectedIndex == 2)
                {
                    if (veiculo is Camioneta)
                    {
                        Camioneta camioneta = (Camioneta)veiculo;
                        dataGridViewVeiculos.Rows.Add(veiculo.IdVeiculo, camioneta.Matricula, camioneta.Marca, camioneta.Modelo, camioneta.Estado, camioneta.Combustivel, camioneta.NumEixos, camioneta.NumPassageiros, camioneta.PrecoDiario);
                    }
                }
                else if (comboBoxTipoVeiculo.SelectedIndex == 3)
                {
                    if (veiculo is Camiao)
                    {
                        Camiao camiao = (Camiao)veiculo;
                        dataGridViewVeiculos.Rows.Add(veiculo.IdVeiculo, camiao.Matricula, camiao.Marca, camiao.Modelo, camiao.Estado, camiao.Combustivel, camiao.PesoMaximo, camiao.PrecoDiario);
                    }
                }
            }
        }

        private void buttonListaVeiculo_Click(object sender, EventArgs e)
        {
            ListaVeiculo listaVeiculo = new ListaVeiculo();
            listaVeiculo.Show();
        }

        private void buttonEditVeiculo_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeiculos.CurrentCell == null)
            {
                MessageBox.Show("Selecione um veículo para editar");
                return;
            }
            else
            {
                MenuEditarVeiculo editarVeiculo = new MenuEditarVeiculo();
                int posicaoListaVeiculo = Program.melresCar.ProcuraPosicaoVeiculoLista(Convert.ToInt32(dataGridViewVeiculos.Rows[dataGridViewVeiculos.CurrentRow.Index].Cells[0].Value));
                editarVeiculo.veiculoSelecionado(posicaoListaVeiculo);
                editarVeiculo.Show();
                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                menuPrincipalObject.Enabled = false;
            }
        }

        private void buttonRemVeiculo_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeiculos.CurrentCell == null)
            {
                MessageBox.Show("Selecione um veículo para remover");
                return;
            }
            else
            {
                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                menuPrincipalObject.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende remover o veículo?", "Remover Veículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    menuPrincipalObject.Enabled = true;
                    return;
                }
                int posicaoListaVeiculo = Program.melresCar.ProcuraPosicaoVeiculoLista(Convert.ToInt32(dataGridViewVeiculos.Rows[dataGridViewVeiculos.CurrentRow.Index].Cells[0].Value));
                Program.melresCar.Veiculos.RemoveAt(posicaoListaVeiculo);
                Program.melresCar.EscreverFicheiroCSV("veiculos");
                atualizaDataGridView(comboBoxTipoVeiculo.SelectedIndex);
                MessageBox.Show("Veículo removido com sucesso");
                menuPrincipalObject.Enabled = true;
            }
        }

        private void buttonAddVeiculo_Click(object sender, EventArgs e)
        {
            MenuAdicionarVeiculo adicionarVeiculo = new MenuAdicionarVeiculo();
            adicionarVeiculo.Show();
            MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
            menuPrincipalObject.Enabled = false;
        }

        private void dungeonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaDataGridView(comboBoxTipoVeiculo.SelectedIndex);
        }

        private void buttonManutencaoVeiculo_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeiculos.CurrentCell == null)
            {
                MessageBox.Show("Selecione um veículo para Manutenção");
                return;
            }
            else
            {
                MenuManutencao manutencao = new MenuManutencao();
                int posicaoListaVeiculo = Program.melresCar.ProcuraPosicaoVeiculoLista(Convert.ToInt32(dataGridViewVeiculos.Rows[dataGridViewVeiculos.CurrentRow.Index].Cells[0].Value));
                manutencao.veiculoSelecionado(posicaoListaVeiculo);
                manutencao.Show();
                MenuPrincipal menuPrincipalObject = (MenuPrincipal)Application.OpenForms["menuPrincipal"];
                menuPrincipalObject.Enabled = false;
            }
        }
    }
}
