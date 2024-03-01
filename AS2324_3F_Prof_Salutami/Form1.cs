namespace AS2324_3F_Prof_Salutami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaluta_Click(object sender, EventArgs e)
        {
            lblSaluto.Text = "Ciao " + txtNome.Text;

            if (txtNome.Text.ToLower().EndsWith("a"))
                lblSaluto.ForeColor = Color.Pink;
            else
                lblSaluto.ForeColor = Color.Blue;
        }
    }
}
