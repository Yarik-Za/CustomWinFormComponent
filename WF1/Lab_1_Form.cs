using ConverterTxtBoxLibrary;

namespace Lab_1_Form
{
    public partial class Lab_1 : Form
    {
        public Lab_1()
        {
            InitializeComponent();

            this.ControlBox = true; // Включаем элементы управления окна
            this.MinimizeBox = false; // Скрываем кнопку "Свернуть"
            this.MaximizeBox = false; // Скрываем кнопку "Развернуть во весь экран"
            //this.Resize += Lab_1_Resize;

            // Подписываемся на событие ErrorOccurred компонента
            convCmToInch.ErrorOccurred += ConvCmToInch_ErrorOccurred;
        }

        // Метод для обработки события ErrorOccurred
        private void ConvCmToInch_ErrorOccurred(object sender, ErrorEventArgs e)
        {
            // Получаем информацию об ошибке из аргументов события
            Exception error = e.GetException(); 

            // Обрабатываем ошибку
            MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
