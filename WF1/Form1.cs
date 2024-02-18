using ConverterTxtBoxLibrary;

namespace WF1
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

            try
            {

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        // Метод для обработки события ErrorOccurred
        private void ConvCmToInch_ErrorOccurred(object sender, ErrorEventArgs e)
        {
            // Получаем информацию об ошибке из аргументов события
            Exception error = e.GetException(); // Изменение здесь

            // Обрабатываем ошибку
            MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
