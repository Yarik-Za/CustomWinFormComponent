using ConverterTxtBoxLibrary;

namespace Lab_1_Form
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
        }

        // ����� ��� ��������� ������� ErrorOccurred
        private void ConvCmToInch_ErrorOccurred(object sender, ErrorEventArgs e)
        {
            // �������� ���������� �� ������ �� ���������� �������
            Exception error = e.GetException(); 

            // ������������ ������
            MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
