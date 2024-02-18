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

        //private void Lab_1_Resize(object sender, EventArgs e)
        //{
        //    // Вычисляем новые размеры для текстовых полей компонента
        //    int newWidth = this.ClientSize.Width - 100; // Пример вычисления новой ширины

        //    // Устанавливаем новые размеры для компонента
        //    convCmToInch.Size = new Size(newWidth, convCmToInch.Height);
        //}

        //private void convCmToInch_SizeChanged(object sender, EventArgs e)
        //{
        //    // Вычисляем новые размеры внутренних элементов
        //    int textBoxWidth = (this.Width - 10) / 2; // Разделяем ширину на два для двух текстовых полей
        //    int textBoxHeight = this.Height - 10; // Задаем высоту текстовых полей

        //    // Устанавливаем новые размеры для внутренних элементов
        //    convCmToInch.CM.Size = new Size(textBoxWidth, textBoxHeight);
        //    convCmToInch.Inch.Size = new Size(textBoxWidth, textBoxHeight);

        //    // Вычисляем позиции для размещения в центре
        //    int textBoxLeft = (this.Width - textBoxWidth * 2) / 2;
        //    int textBoxTop = (this.Height - textBoxHeight) / 2;

        //    // Устанавливаем новые позиции для внутренних элементов
        //    convCmToInch.CM.Size.Location = new Point(textBoxLeft, textBoxTop);
        //    convCmToInch.Inch.Location = new Point(textBoxLeft + textBoxWidth, textBoxTop);
        //}
    }
}
