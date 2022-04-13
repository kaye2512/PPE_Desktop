namespace PPE_Desktop1
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }
        Form2 MyForm = new Form2();
        private void btGenere_MouseClick(object sender, MouseEventArgs e)
        {

            MyForm.Show();

        }
    }
}