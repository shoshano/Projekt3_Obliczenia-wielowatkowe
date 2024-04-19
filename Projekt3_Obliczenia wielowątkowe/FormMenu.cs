namespace Projekt3_Obliczenia_wielowątkowe
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void Matrix_Click(object sender, EventArgs e)
        {
            FormMatrix newform = new FormMatrix();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }

        private void Image_Click(object sender, EventArgs e)
        {
            FormImage newform = new FormImage();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }
    }
}
