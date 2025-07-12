namespace Password 
{
    partial class Form1  
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.checkBoxMaj = new System.Windows.Forms.CheckBox();
            this.checkBoxNb = new System.Windows.Forms.CheckBox();
            this.checkBoxSpe = new System.Windows.Forms.CheckBox();
            this.labelLet = new System.Windows.Forms.Label();
            this.labelCaract = new System.Windows.Forms.Label();
            this.labelSpecialCar = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.numericUpDownLet = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCaract = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeCar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLetters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpecialChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalLength)).BeginInit();
