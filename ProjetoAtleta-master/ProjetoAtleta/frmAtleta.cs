using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class frmAtleta : Form
    {
        public frmAtleta()
        {
            InitializeComponent();
        }
        Atleta obj = new Atleta();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            try
            {
                obj.SetNome(txtnome.Text);

                string y = txtpeso.Text;
                var p = y.Replace(".", ",");
                var b = p.Replace("-", "");
                obj.SetPeso(double.Parse(b));

                string x = txtaltura.Text;
                var o = x.Replace(".", ",");
                var u = o.Replace("-", "");
                obj.SetAltura(double.Parse(u));

                obj.SetIdade(int.Parse(txtidade.Text));

                txtresultado.Text = obj.CalculaIMC().ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Erro: Divisão por zero");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro \n Digite todos os dados!");
            }

        }

        private void frmAtleta_Load(object sender, EventArgs e)
        {

        }
    }
}
