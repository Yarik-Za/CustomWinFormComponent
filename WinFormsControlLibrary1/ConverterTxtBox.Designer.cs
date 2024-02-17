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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxCM
            // 
            textBoxCM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCM.Location = new Point(3, 22);
            textBoxCM.Name = "textBoxCM";
            textBoxCM.Size = new Size(155, 23);
            textBoxCM.TabIndex = 0;
            textBoxCM.TextChanged += textBoxCM_TextChanged;
            textBoxCM.KeyPress += textBox_KeyPress;
            // 
            // textBoxInch
            // 
            textBoxInch.Location = new Point(3, 76);
            textBoxInch.Name = "textBoxInch";
            textBoxInch.Size = new Size(155, 23);
            textBoxInch.TabIndex = 1;
            textBoxInch.TextChanged += textBoxInch_TextChanged;
            textBoxInch.KeyPress += textBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 4);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "centimeters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 58);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "inches";
            // 
            // ConverterTxtBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxInch);
            Controls.Add(textBoxCM);
            Name = "ConverterTxtBox";
            Size = new Size(162, 102);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCM;
        private TextBox textBoxInch;
        private Label label1;
        private Label label2;
    }
}
