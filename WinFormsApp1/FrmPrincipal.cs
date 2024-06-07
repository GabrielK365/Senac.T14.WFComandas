using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Cardapio_Click(object sender, EventArgs e)
        {
            new frmCardapio().ShowDialog();
        }

        private void Comanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void Pedido_Click(object sender, EventArgs e)
        {
            new frmPedidoCozinha().ShowDialog();
        }

    }
}
