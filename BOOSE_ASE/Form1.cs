using System.Diagnostics;
using BOOSE;


namespace BOOSE_ASE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine(AboutBOOSE.about());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
