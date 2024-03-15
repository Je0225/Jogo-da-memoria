using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace JogoDaMemoria {

    public partial class FormPrincipal: Form {

        private Random random { get; }
        private readonly List<Button> botoes;
        private readonly List<Object> opcoes;
        private readonly List<Button> botoesClicados;
        private readonly TipoJogo tipoJogo;

        public FormPrincipal(TipoJogo tipoJogo) {
            InitializeComponent();
            random = new Random();
            botoes = new List<Button>();
            opcoes = new List<Object>();
            botoesClicados = new List<Button>();
            this.tipoJogo = tipoJogo;

            PreencheListaDeOpcoes();

            foreach (Control objeto in Controls) {
                if (objeto is Button) {
                    botoes.Add((Button)objeto);
                }
            }

            AddTagDosBotoes();
        }

        private Object GeraOpcao() {
            switch (tipoJogo) {
                case TipoJogo.Letras:
                    return Convert.ToChar(random.Next(65, 91)); 
                case TipoJogo.Numeros:
                    return random.Next(65, 91);
                case TipoJogo.Cores:
                    Int32 r = random.Next(0, 256);
                    Int32 g = random.Next(0, 256);
                    Int32 b = random.Next(0, 256);
                    return Color.FromArgb(r, g, b);
                 default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void PreencheListaDeOpcoes() {
            while (opcoes.Count < 18) {
                Object opcao = GeraOpcao();
                if (!opcoes.Contains(opcao)) {
                    opcoes.Add(opcao);
                }
            }
        }

        private void AddTagDosBotoes() {
            List<Button> tags = new List<Button>(botoes);

            foreach (Object opcao in opcoes) {
                int posicao = random.Next(0, tags.Count);
                Button botao = tags[posicao];
                botao.Tag = opcao;
                tags.Remove(botao);

                posicao = random.Next(0, tags.Count);
                botao = tags[posicao];
                botao.Tag = opcao;
                tags.Remove(botao);
            }
        }

        private void btn_Click(object sender, EventArgs e) {
            Button botaoClicado = (Button)sender;
            botoesClicados.Add(botaoClicado);

            if (tipoJogo.Equals(TipoJogo.Cores)) {
                botaoClicado.BackColor = (Color)botaoClicado.Tag;
            } else {
                botaoClicado.Text = botaoClicado.Tag.ToString();
            }
            botaoClicado.Enabled = false;

            if (botoesClicados.Count.Equals(2)) {
                ChecaBotoes();
            }
        }

        private void ChecaBotoes() {
            if (!botoesClicados[0].Tag.Equals(botoesClicados[1].Tag)) {
                Thread.Sleep(1000);
                foreach (Button botao in botoesClicados) {
                    botao.Enabled = true;
                    if (tipoJogo == TipoJogo.Cores) {
                        botao.BackColor = default(Color);
                        botao.UseVisualStyleBackColor = true;
                    } else {
                        botao.Text = "";
                    }
                }
            }
            botoesClicados.Clear();
        }

    }

}