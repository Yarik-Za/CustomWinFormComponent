namespace ConverterTxtBoxLibrary
{
    public partial class ConverterTxtBox : UserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCM = new TextBox();
            textBoxInch = new TextBox();
            labelCM = new Label();
            labelInch = new Label();
            SuspendLayout();
            // 
            // textBoxCM
            // 
            textBoxCM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCM.Location = new Point(3, 22);
            textBoxCM.Name = "textBoxCM";
            textBoxCM.Size = new Size(156, 23);
            textBoxCM.TabIndex = 0;
            textBoxCM.TextChanged += textBox_TextChanged;
            textBoxCM.KeyPress += textBox_KeyPress;
            // 
            // textBoxInch
            // 
            textBoxInch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInch.Location = new Point(3, 76);
            textBoxInch.Name = "textBoxInch";
            textBoxInch.Size = new Size(156, 23);
            textBoxInch.TabIndex = 1;
            textBoxInch.TextChanged += textBox_TextChanged;
            textBoxInch.KeyPress += textBox_KeyPress;
            // 
            // labelCM
            // 
            labelCM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCM.AutoSize = true;
            labelCM.Location = new Point(45, 4);
            labelCM.Name = "labelCM";
            labelCM.Size = new Size(69, 15);
            labelCM.TabIndex = 2;
            labelCM.Text = "centimeters";
            // 
            // labelInch
            // 
            labelInch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelInch.AutoSize = true;
            labelInch.Location = new Point(56, 58);
            labelInch.Name = "labelInch";
            labelInch.Size = new Size(41, 15);
            labelInch.TabIndex = 3;
            labelInch.Text = "inches";
            // 
            // ConverterTxtBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(labelInch);
            Controls.Add(labelCM);
            Controls.Add(textBoxInch);
            Controls.Add(textBoxCM);
            Name = "ConverterTxtBox";
            Size = new Size(163, 105);
            Resize += ConverterTxtBox_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCM;
        private TextBox textBoxInch;
        private Label labelCM;
        private Label labelInch;
    }
}
