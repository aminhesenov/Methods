namespace Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /*Parametrsiz metodlar*/
        void setPanel1()
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Green;
        }
        /*Parametrli metodlar*/
        void setPanel2(Panel panel, Color backcolor) { 
            panel4.BackColor = backcolor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setPanel1();
            setPanel2(panel4, Color.Yellow);
        }
    }
}
