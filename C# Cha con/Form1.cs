namespace C__Cha_con
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ChildForm_1 cf1 = new ChildForm_1();
            cf1.MdiParent = this;
            cf1.Show();
        }
    }
}
