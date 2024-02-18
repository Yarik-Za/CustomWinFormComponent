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

                if (e.KeyChar == '-' && (textBox.Text.Length == 0 || textBox.SelectionStart != 0))
                {
                    e.Handled = true;
                    throw new ArgumentException("Negative numbers are not allowed.");
                }

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != 'E' && e.KeyChar != '+' && e.KeyChar != '-')
                {
                    e.Handled = true;
                    throw new ArgumentException("Attempt of invalid input was stopped");
                }

                if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                    throw new ArgumentException("More than one separator was typed!");
                }
            }
            catch (Exception ex) { OnErrorOccurred(ex); }
        }

        private void ConverterTxtBox_Resize(object sender, EventArgs e)
        {
            UpdateInternalElements();
        }

        private void UpdateInternalElements()
        {
            int textBoxHeight = this.Height / 3;

            labelCM.Location = new Point((this.Width - labelCM.Width) / 2, 5);
            labelInch.Location = new Point((this.Width - labelInch.Width) / 2, textBoxHeight + 10);

            textBoxCM.Size = new Size(this.Width, textBoxHeight);
            textBoxInch.Size = new Size(this.Width, textBoxHeight);

            textBoxCM.Location = new Point(0, labelCM.Bottom);
            textBoxInch.Location = new Point(0, labelInch.Bottom + 5);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            TextChanges(textBox);
        }

        private void TextChanges(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return;
            }

            if (!double.TryParse(textBox.Text, out double value))
            {
                OnErrorOccurred(new FormatException("Invalid input. Please enter a valid number."));
                return;
            }

            if (value < 0)
            {
                OnErrorOccurred(new ArgumentException("Negative numbers are not allowed."));
                return;
            }

            if (textBox == textBoxCM)
            {
                CM = value;
            }
            else if (textBox == textBoxInch)
            {
                Inch = value;
            }
        }
    }
}
