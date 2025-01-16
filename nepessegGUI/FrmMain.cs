using System.Text;

namespace nepessegGUI
{
    public partial class FrmMain : Form
    {

        const string path = "H:\\c#\\forms apps\\nepesseg\\nepessegCLI\\src\\ujadat.txt";

        public FrmMain()
        {
            InitializeComponent();

            btnKilepes.Click += BtnKilepesClick;
            btnMentes.Click += BtnMentesClick;

        }

        private void BtnMentesClick(object? sender, EventArgs e)
        {
            _ = int.TryParse(tbxTerulet.Text, out int terulet);
            _ = int.TryParse(tbxNepesseg.Text, out int nepesseg);
            _ = int.TryParse(tbxFovarosLakossag.Text, out int fovarosLakossag);

            if (fovarosLakossag > nepesseg)
            {
                lblUzenet.ForeColor = Color.Red;
                lblUzenet.Text = "A fovaros lakossaga nem lehet tobb az orszag nepessegenel! ";
                lblNepesseg.Text = tbxFovarosLakossag.Text;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path, append: true, Encoding.UTF8))
                {
                    writer.WriteLine($"{tbxOrszag.Text};{tbxTerulet};{tbxNepesseg};{tbxFovaros};{tbxFovarosLakossag}");
                    lblUzenet.ForeColor = Color.Green;
                    lblUzenet.Text = "A mentes sikeres! ";
                }
            }
        }

        private void BtnKilepesClick(object? sender, EventArgs e) => Application.Exit();

        /*
        private void BtnKilepesClick(object? sender, EventArgs e)
        {
            Application.Exit();
        }
        */


    }
}
