﻿namespace Lab_1_Form
{
    partial class Lab_1
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
            convCmToInch = new ConverterTxtBoxLibrary.ConverterTxtBox();
            SuspendLayout();
            // 
            // convCmToInch
            // 
            convCmToInch.CM = 1D;
            convCmToInch.Inch = 0.39370078740157477D;
            convCmToInch.Location = new Point(10, 7);
            convCmToInch.Name = "convCmToInch";
            convCmToInch.Size = new Size(150, 102);
            convCmToInch.TabIndex = 0;
            // 
            // Lab_1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(168, 109);
            Controls.Add(convCmToInch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Lab_1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private ConverterTxtBoxLibrary.ConverterTxtBox convCmToInch;
    }
}
