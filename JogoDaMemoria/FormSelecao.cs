using System;
using System.Windows.Forms;

namespace JogoDaMemoria {

    public partial class FormSelecao: Form {

        public TipoJogo JogoSelecionado {
            get {
                if (rbCores.Checked) {
                    return TipoJogo.Cores;
                }
                if (rbLetras.Checked) {
                    return TipoJogo.Letras;
                }
                return TipoJogo.Numeros;
            }
        }

        public FormSelecao() {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }

}