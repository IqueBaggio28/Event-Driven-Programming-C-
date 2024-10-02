namespace Math_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int dificulty;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && !radioButton.Checked == true)
                {
                    btnPlay.Enabled = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random rand = new Random();


            if (rbEasy.Checked)
            {
                dificulty = 1;

            }
            else if (rbMedium.Checked)
            {
                dificulty = 2;
            }
            else
            {
                dificulty = 3;
            }
            



            Game frm = new Game(dificulty);
            frm.Show();
        }

        
    }
}
