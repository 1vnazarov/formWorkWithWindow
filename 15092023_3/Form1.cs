namespace _15092023_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width), (0));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
        }

        private void btn_rightBottom_Click(object sender, EventArgs e)
        {
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width), (Screen.PrimaryScreen.WorkingArea.Height - Height));
        }

        private void btn_leftTop_Click(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
        }

        private void btn_leftBottom_Click(object sender, EventArgs e)
        {
            Location = new Point(0, (Screen.PrimaryScreen.WorkingArea.Height - Height));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_restoreWindow_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Normal;
        }

        private void defaultSize_Click(object sender, EventArgs e)
        {
            Size = new Size(816, 489);
        }

        private void size2_Click(object sender, EventArgs e)
        {
            Size = new Size(839, 464);
        }

        private void size3_Click(object sender, EventArgs e)
        {
            Size = new Size(939, 564);
        }
    }
}