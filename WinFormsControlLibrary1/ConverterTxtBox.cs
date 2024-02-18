namespace ConverterTxtBoxLibrary
{
    [ToolboxBitmap(@"C:\Users\Yarik\source\repos\APPZ_Lab1_Zaychenko_622п\WinFormsControlLibrary1\ConverterTxtBox.ico")]
    public partial class ConverterTxtBox : UserControl
    {
        private double cm;
        private double inch;

        public ConverterTxtBox()
        {
            InitializeComponent();
            textBoxCM.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            textBoxInch.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        }

        public double CM
        {
            get { return cm; }
            set
            {
                if (cm != value)
                {
                    cm = value;
                    textBoxCM.Text = value.ToString();
                    inch = value / 2.54;
                    textBoxInch.Text = inch.ToString();
                    OnCMChanged();
                }
            }
        }

        public double Inch
        {
            get { return inch; }
            set
            {
                if (inch != value)
                {
                    inch = value;
                    textBoxInch.Text = value.ToString();
                    cm = value * 2.54;
                    textBoxCM.Text = cm.ToString();
                    OnInchChanged();
                }
            }
        }

        public event EventHandler CMChanged;
        public event EventHandler InchChanged;
        public event EventHandler<ErrorEventArgs> ErrorOccurred;

        protected virtual void OnCMChanged()
        {
            CMChanged?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnInchChanged()
        {
            InchChanged?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnErrorOccurred(Exception ex)
        {
            ErrorOccurred?.Invoke(this, new ErrorEventArgs(ex));
        }

        private void textBoxCM_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCM.Text, out double newCM))
            {
                CM = newCM;
            }
        }

        private void textBoxInch_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxInch.Text, out double newInch))
            {
                Inch = newInch;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Перевірка, чи є введений символ цифрою, крапкою або комою, або клавішею Backspace
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    // Якщо введений символ не є цифрою, крапкою, комою або Backspace, скасувати введення
                    e.Handled = true;
                    throw new Exception("Atemp of invalid input was stopped");
                }

                // Перевірка, чи введений символ - крапка або кома, і чи вони вже присутні у тексті
                if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1))
                {
                    // Якщо введено більше однієї крапки або коми, скасувати введення
                    e.Handled = true;
                    throw new Exception("More than one separator was typed!");
                }
            }
            catch (Exception ex) { OnErrorOccurred(ex); }
        }

        //private void ConverterTxtBox_SizeChanged(object sender, EventArgs e)
        //{
        //    // Вычисляем новые размеры внутренних элементов
        //    int textBoxWidth = (this.Width - 10) / 2; // Разделяем ширину на два для двух текстовых полей
        //    int textBoxHeight = this.Height - 10; // Задаем высоту текстовых полей

        //    // Устанавливаем новые размеры для внутренних элементов
        //    textBoxCM.Size = new Size(textBoxWidth, textBoxHeight);
        //    textBoxInch.Size = new Size(textBoxWidth, textBoxHeight);

        //    // Вычисляем позиции для размещения в центре
        //    int textBoxLeft = (this.Width - textBoxWidth * 2) / 2;
        //    int textBoxTop = (this.Height - textBoxHeight) / 2;

        //    // Устанавливаем новые позиции для внутренних элементов
        //    textBoxCM.Location = new Point(textBoxLeft, textBoxTop);
        //    textBoxInch.Location = new Point(textBoxLeft + textBoxWidth, textBoxTop);
        //}

        private void ConverterTxtBox_SizeChanged(object sender, EventArgs e)
        {
            // Вычисляем новую высоту для текстовых полей
            int textBoxHeight = (this.Height - 10) / 3; // Разделяем высоту на три части: для текстовых полей и промежутков между ними

            // Устанавливаем новые размеры для текстовых полей
            textBoxCM.Size = new Size(textBoxCM.Width, textBoxHeight);
            textBoxInch.Size = new Size(textBoxInch.Width, textBoxHeight);

            // Вычисляем позицию для первого текстового поля (высота на промежуток между текстовыми полями)
            int textBoxTop = 5; // Начальная позиция по вертикали

            // Устанавливаем новые позиции для текстовых полей и лейбла
            labelCM.Location = new Point(labelCM.Left, textBoxTop);
            textBoxCM.Location = new Point(textBoxCM.Left, textBoxTop + labelCM.Height);
            textBoxInch.Location = new Point(textBoxInch.Left, textBoxTop + labelCM.Height + textBoxHeight);
        }

    }
}
