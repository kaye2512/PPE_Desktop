namespace PPE_Desktop1
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }
        Generer MyForm = new Generer();
        Ajouter MyAjout = new Ajouter();
        Recherche MyRecherche = new Recherche();
        private void btGenere_MouseClick(object sender, MouseEventArgs e)
        {

            MyForm.Show();

        }

        private void btAjout_MouseClick(object sender, MouseEventArgs e)
        { 
           
                MyAjout.Show();

           
            
        }

        private void btRecherche_MouseClick(object sender, MouseEventArgs e)
        {
            MyRecherche.Show();
        }
    }
}