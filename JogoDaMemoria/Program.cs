using System;
using System.Windows.Forms;

namespace JogoDaMemoria {

    internal static class Program {

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormSelecao formSelecao = new FormSelecao();
            DialogResult result = formSelecao.ShowDialog();
            
            if (result == DialogResult.OK) {
                Application.Run(new FormPrincipal(formSelecao.JogoSelecionado));
            }
        }

    }

}