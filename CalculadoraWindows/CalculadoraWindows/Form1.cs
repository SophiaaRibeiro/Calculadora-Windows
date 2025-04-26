using System.Windows.Forms;
using System;

using System;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;

namespace CalculadoraWindows
{
    public partial class Form1 : Form
    {
        double pNum = 0;
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        string operacao = "";
        decimal memoria = 0;
        private List <decimal> Ms = new List<decimal>();


        private enum Operacao
        {
            Adicao,
            Divisao,
            Multiplicacao,
            Subtracao,
            RaizQuadrada,
            Porcentagem,
            AoQuadrado
        }

        public Form1()
        {
            InitializeComponent();
            TxtResultado.Text = "0";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {

            if (TxtResultado.Text == "0")
                TxtResultado.Text = "0";
            else
                TxtResultado.Text += "0";


        }

        private void BtnUm_Click(object sender, EventArgs e)
        {

            if (TxtResultado.Text == "0")
                TxtResultado.Text = "1";
                else
                TxtResultado.Text += "1";
           
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "2";
            else
                TxtResultado.Text += "2";

        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "3";
            else
                TxtResultado.Text += "3";

        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "4";
            else
                TxtResultado.Text += "4";


        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "5";
            else
                TxtResultado.Text += "5";

        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "6";
            else
                TxtResultado.Text += "6";

        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "7";
            else
                TxtResultado.Text += "7";

        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "8";
            else
                TxtResultado.Text += "8";

        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text == "0")
                TxtResultado.Text = "9";
            else
                TxtResultado.Text += "9";

        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                OperacaoSelecionada = Operacao.Divisao;
                Valor = Convert.ToDecimal(TxtResultado.Text);
                TxtNumeros.Text = Valor + "/";
                TxtResultado.Text = string.Empty;
            }
           
            
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                OperacaoSelecionada = Operacao.Multiplicacao;
                Valor = Convert.ToDecimal(TxtResultado.Text);
                TxtNumeros.Text = TxtResultado.Text + "*";
                TxtResultado.Text = string.Empty;

            }


        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                OperacaoSelecionada = Operacao.Subtracao;
                Valor = Convert.ToDecimal(TxtResultado.Text);
                TxtNumeros.Text = TxtResultado.Text + "-";
                TxtResultado.Text = string.Empty;
            }
           

        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                OperacaoSelecionada = Operacao.Adicao;
                Valor = Convert.ToDecimal(TxtResultado.Text);
                TxtNumeros.Text = Valor + "+";
                TxtResultado.Text = string.Empty;
            }
           
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                switch (OperacaoSelecionada)
                {
                    case Operacao.Adicao:
                        pNum = Convert.ToDouble(TxtResultado.Text);
                        Resultado = Valor + Convert.ToDecimal(TxtResultado.Text);
                        TxtNumeros.Text = Valor + "+" + Convert.ToString(pNum) + "=";
                        TxtResultado.Text = Convert.ToString(Resultado);
                        string textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
                        listBox1.Items.Add(textBox);
                        break;

                    case Operacao.Subtracao:
                        pNum = Convert.ToDouble(TxtResultado.Text);
                        Resultado = Valor - Convert.ToDecimal(TxtResultado.Text);
                        TxtNumeros.Text = Valor + "-" + Convert.ToString(pNum) + "=";
                        TxtResultado.Text = Convert.ToString(Resultado);
                        textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
                        listBox1.Items.Add(textBox);
                        break;

                    case Operacao.Multiplicacao:
                        pNum = Convert.ToDouble(TxtResultado.Text);
                        Resultado = Valor * Convert.ToDecimal(TxtResultado.Text);
                        TxtNumeros.Text = Valor + "x" + Convert.ToString(pNum) + "=";
                        TxtResultado.Text = Convert.ToString(Resultado);
                        textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
                        listBox1.Items.Add(textBox);
                        break;

                    case Operacao.Divisao:
                        pNum = Convert.ToDouble(TxtResultado.Text);
                        Resultado = Valor / Convert.ToDecimal(TxtResultado.Text);
                        TxtNumeros.Text = Valor + "/" + Convert.ToString(pNum) + "=";
                        TxtResultado.Text = Convert.ToString(Resultado);
                        textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
                        listBox1.Items.Add(textBox);
                        break;
                }
            }
            

           
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtResultado.Clear();
            TxtNumeros.Clear();
            TxtResultado.Text = "0";
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if (!TxtResultado.Text.Contains(","))
            {
                TxtResultado.Text += ",";
            }
        }

        private void TxtNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnXaoQuadrado_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.AoQuadrado;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            Resultado = Valor * Valor;
            TxtResultado.Text = Resultado.ToString();
            string textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
            listBox1.Items.Add(textBox);
        }

        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.RaizQuadrada;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            Resultado = (decimal)Math.Sqrt((double)Valor);
            TxtResultado.Text = Resultado.ToString();
            string textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
            listBox1.Items.Add(textBox);
        }

        private void BtnPorcetagem_Click(object sender, EventArgs e)
        {
            if (Valor != 0 && TxtResultado.Text != "")
            {
                pNum = Convert.ToDouble(TxtResultado.Text);
                Resultado = Valor * (Convert.ToDecimal(pNum) / 100);
                TxtResultado.Text = Resultado.ToString();
                TxtNumeros.Text = $"{Valor} % {pNum} = {Resultado}";
                string textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
                listBox1.Items.Add(textBox);
            }
        }

            private void BtnExcloir_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text.Length > 0)
            {
                TxtResultado.Text = TxtResultado.Text.Substring(0, TxtResultado.Text.Length - 1);
            }
            else
            {
                TxtResultado.Text = "0";
            }
        }

        private void BtnLimparTudo_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = string.Empty;
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnMenosEmais_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                double valorAtual = Convert.ToDouble(TxtResultado.Text);
                valorAtual *= -1;
                TxtResultado.Text = valorAtual.ToString();
                string textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
                listBox1.Items.Add(textBox);
            }
        }

        private void BtnUmporX_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                double valorAtual = Convert.ToDouble(TxtResultado.Text);
                if (valorAtual != 0)
                {
                    double resultado = 1 / valorAtual;
                    TxtResultado.Text = resultado.ToString();
                    TxtNumeros.Text = $"1/{valorAtual} = {resultado}";
                    string textBox = TxtNumeros.Text + Convert.ToString(TxtResultado.Text);
                    listBox1.Items.Add(textBox);
                }
                else
                {
                    TxtResultado.Text = "Erro";
                }
            }
        }

        private void LinkLblMC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox2.Items.Clear();
            memoria = 0;

        }

        private void linkLblMR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (memoria != 0)
            {
                TxtResultado.Text = memoria.ToString();
            }
            else
            {
                TxtResultado.Text = "0";
            }
        }

        private void LinlLblMmais_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            memoria += Convert.ToDecimal(TxtResultado.Text); ;
            listBox2.Items.Add(memoria);
        }

        private void LinklLblMmenos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             memoria -= Convert.ToDecimal(TxtResultado.Text);
            listBox2.Items.Add(memoria);
        }

        private void LinkLblMS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            memoria = Convert.ToDecimal(TxtResultado.Text);
            listBox2.Items.Add(memoria);
        }

        private void LinkLblM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox2.Visible = !listBox2.Visible;
            listBox2.Location = new Point(19, 120);
            //   if (listBox2.Visible == true)
            //     {
            //        ListBox Ms2 = new ListBox();
            //        listBox2.Visible = false;
            //     }
            //    else
            //    {
            //      listBox2.Visible = true;
            //      listBox2.Location = new Point(30, 120);

            //  }
        }

        private void Historico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(listBox1.Visible == true)
            { 
            ListBox historico = new ListBox();
            listBox1.Visible = false;
                LinkLblMC.Enabled = true;
                LinkLblM.Enabled = true;
                LinlLblMmais.Enabled = true;
                LinklLblMmenos.Enabled = true;
                linkLblMR.Enabled = true;
                LinkLblMS.Enabled = true;
            }
            else
            {
                listBox1.Visible = true;
                listBox1.Location = new Point(19, 120);
                LinkLblMC.Enabled = false;
                LinkLblM.Enabled = false;
                LinlLblMmais.Enabled = false;
                LinklLblMmenos.Enabled = false;
                linkLblMR.Enabled = false;
                LinkLblMS.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox historico = new ListBox();

        }
    }
}