namespace Tutorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardfacePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void showfaceButton_Click(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = false;
            cardfacePictureBox.Visible = true;
        }

        private void showbackButton_Click(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = true;
            cardfacePictureBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = false;
            cardfacePictureBox.Visible = false;
        }
    }
}
