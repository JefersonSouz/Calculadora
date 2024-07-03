using System.Diagnostics;

namespace Calculadora
{

    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecao { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecao = Operacao.Adicao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            label1.Text = "+";
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecao = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            label1.Text = "-";
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecao = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            label1.Text = "X";
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecao = Operacao.Divisao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            label1.Text = "/";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecao)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textResultado.Text);
                    break;

            }
            textResultado.Text = Convert.ToString(Resultado);
            label1.Text = "=";
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains(","))
                textResultado.Text += ",";
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            label1.Text = "";
        }
    }

}
