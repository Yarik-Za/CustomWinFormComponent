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

            this.Resize += ConverterTxtBox_Resize;
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

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;

                // Проверка на ввод минуса в начале строки
                if (e.KeyChar == '-' && textBox.SelectionStart == 0)
                {
                    e.Handled = true; // Отменяем ввод
                    throw new Exception("Negative numbers are not allowed.");
                }


                // Перевірка, чи є введений символ цифрою, крапкою або комою, або клавішею Backspace
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != 'E' && e.KeyChar != '+' && e.KeyChar != '-')
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

        private void ConverterTxtBox_Resize(object sender, EventArgs e)
        {
            // Размеры компонента изменились, пересчитываем размеры и позиции внутренних элементов
            UpdateInternalElements();
        }
        private void UpdateInternalElements()
        {
            // Определяем высоту текстового поля как 1/3 высоты компонента
            int textBoxHeight = this.Height / 3;

            // Устанавливаем размер и позицию для лейблов
            labelCM.Location = new Point((this.Width - labelCM.Width) / 2, 5);
            labelInch.Location = new Point((this.Width - labelInch.Width) / 2, textBoxHeight + 10);

            // Устанавливаем размеры для текстовых полей
            textBoxCM.Size = new Size(this.Width, textBoxHeight);
            textBoxInch.Size = new Size(this.Width, textBoxHeight);

            // Устанавливаем позиции для текстовых полей
            textBoxCM.Location = new Point(0, labelCM.Bottom);
            textBoxInch.Location = new Point(0, labelInch.Bottom + 5);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                // Попробуйте распарсить введенное значение как число
                double value = double.Parse(textBox.Text);

                // Проверяем, если число меньше 0, выводим сообщение об ошибке
                if (value < 0)
                {
                    throw new Exception("Negative numbers are not allowed.");
                }

                // Обработка для поля CM
                if (textBox == textBoxCM)
                {
                    CM = value;
                }
                // Обработка для поля Inch
                else if (textBox == textBoxInch)
                {
                    Inch = value;
                }
            }
            catch (FormatException)
            {
                // Выводим сообщение об ошибке, если введенное значение не является числом
                OnErrorOccurred(new Exception("Invalid input. Please enter a valid number."));
            }
            catch (Exception ex)
            {
                // Выводим сообщение об ошибке только если это не отрицательное число
                if (ex.Message != "Negative numbers are not allowed.")
                {
                    OnErrorOccurred(ex);
                }
            }
            finally
            {
                textBoxCM.Clear();
                textBoxInch.Clear();
            }
        }
    }
}