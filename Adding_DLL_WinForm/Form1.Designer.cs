namespace Adding_DLL_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            converterTxtBox1 = new ConverterTxtBoxLibrary.ConverterTxtBox();
            SuspendLayout();
            // 
            // converterTxtBox1
            // 
            converterTxtBox1.CM = 0D;
            converterTxtBox1.Inch = 0D;
            converterTxtBox1.Location = new Point(38, 41);
            converterTxtBox1.Name = "converterTxtBox1";
            converterTxtBox1.Size = new Size(685, 355);
            converterTxtBox1.TabIndex = 0;
            converterTxtBox1.ErrorOccurred += converterTxtBox1_ErrorOccurred;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(converterTxtBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ConverterTxtBoxLibrary.ConverterTxtBox converterTxtBox1;
    }
}
