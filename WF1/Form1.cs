using ConverterTxtBoxLibrary;

namespace WF1
{
    public partial class Lab_1 : Form
    {
        public Lab_1()
        {
            InitializeComponent();


            this.ControlBox = true; // �������� �������� ���������� ����
            this.MinimizeBox = false; // �������� ������ "��������"
            this.MaximizeBox = false; // �������� ������ "���������� �� ���� �����"
            //this.Resize += Lab_1_Resize;

            // ������������� �� ������� ErrorOccurred ����������
            convCmToInch.ErrorOccurred += ConvCmToInch_ErrorOccurred;

            try
            {

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        // ����� ��� ��������� ������� ErrorOccurred
        private void ConvCmToInch_ErrorOccurred(object sender, ErrorEventArgs e)
        {
            // �������� ���������� �� ������ �� ���������� �������
            Exception error = e.GetException(); // ��������� �����

            // ������������ ������
            MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //private void Lab_1_Resize(object sender, EventArgs e)
        //{
        //    // ��������� ����� ������� ��� ��������� ����� ����������
        //    int newWidth = this.ClientSize.Width - 100; // ������ ���������� ����� ������

        //    // ������������� ����� ������� ��� ����������
        //    convCmToInch.Size = new Size(newWidth, convCmToInch.Height);
        //}

        //private void convCmToInch_SizeChanged(object sender, EventArgs e)
        //{
        //    // ��������� ����� ������� ���������� ���������
        //    int textBoxWidth = (this.Width - 10) / 2; // ��������� ������ �� ��� ��� ���� ��������� �����
        //    int textBoxHeight = this.Height - 10; // ������ ������ ��������� �����

        //    // ������������� ����� ������� ��� ���������� ���������
        //    convCmToInch.CM.Size = new Size(textBoxWidth, textBoxHeight);
        //    convCmToInch.Inch.Size = new Size(textBoxWidth, textBoxHeight);

        //    // ��������� ������� ��� ���������� � ������
        //    int textBoxLeft = (this.Width - textBoxWidth * 2) / 2;
        //    int textBoxTop = (this.Height - textBoxHeight) / 2;

        //    // ������������� ����� ������� ��� ���������� ���������
        //    convCmToInch.CM.Size.Location = new Point(textBoxLeft, textBoxTop);
        //    convCmToInch.Inch.Location = new Point(textBoxLeft + textBoxWidth, textBoxTop);
        //}
    }
}
