namespace Adding_DLL_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void converterTxtBox1_ErrorOccurred(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.GetException().Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
