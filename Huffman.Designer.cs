namespace HuffmanCode
{
    partial class Huffman
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            RB_Dekomprimieren = new RadioButton();
            RB_Komprimieren = new RadioButton();
            BTN_Help = new PictureBox();
            BTN_Back = new PictureBox();
            BTN_Start = new PictureBox();
            TB_Output = new TextBox();
            TB_Input = new TextBox();
            TB_PathIn = new TextBox();
            TB_PathOut = new TextBox();
            LBL_Eingabe = new Label();
            LBL_Ausgabe = new Label();
            LBL_Titel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BTN_Help).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Start).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RB_Dekomprimieren);
            groupBox1.Controls.Add(RB_Komprimieren);
            groupBox1.Location = new Point(152, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // RB_Dekomprimieren
            // 
            RB_Dekomprimieren.AutoSize = true;
            RB_Dekomprimieren.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RB_Dekomprimieren.Location = new Point(210, 17);
            RB_Dekomprimieren.Name = "RB_Dekomprimieren";
            RB_Dekomprimieren.Size = new Size(223, 39);
            RB_Dekomprimieren.TabIndex = 1;
            RB_Dekomprimieren.Text = "Dekomprimieren";
            RB_Dekomprimieren.UseVisualStyleBackColor = true;
            // 
            // RB_Komprimieren
            // 
            RB_Komprimieren.AutoSize = true;
            RB_Komprimieren.Checked = true;
            RB_Komprimieren.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RB_Komprimieren.Location = new Point(10, 17);
            RB_Komprimieren.Name = "RB_Komprimieren";
            RB_Komprimieren.Size = new Size(194, 39);
            RB_Komprimieren.TabIndex = 0;
            RB_Komprimieren.TabStop = true;
            RB_Komprimieren.Text = "Komprimieren";
            RB_Komprimieren.UseVisualStyleBackColor = true;
            // 
            // BTN_Help
            // 
            BTN_Help.Image = Properties.Resources.help;
            BTN_Help.Location = new Point(684, 12);
            BTN_Help.Name = "BTN_Help";
            BTN_Help.Size = new Size(120, 120);
            BTN_Help.SizeMode = PictureBoxSizeMode.StretchImage;
            BTN_Help.TabIndex = 1;
            BTN_Help.TabStop = false;
            BTN_Help.Click += BTN_Help_Click;
            // 
            // BTN_Back
            // 
            BTN_Back.Image = Properties.Resources.back;
            BTN_Back.Location = new Point(12, 12);
            BTN_Back.Name = "BTN_Back";
            BTN_Back.Size = new Size(100, 100);
            BTN_Back.SizeMode = PictureBoxSizeMode.StretchImage;
            BTN_Back.TabIndex = 2;
            BTN_Back.TabStop = false;
            BTN_Back.Click += BTN_Back_Click;
            // 
            // BTN_Start
            // 
            BTN_Start.Image = Properties.Resources.go1;
            BTN_Start.Location = new Point(270, 362);
            BTN_Start.Name = "BTN_Start";
            BTN_Start.Size = new Size(260, 91);
            BTN_Start.SizeMode = PictureBoxSizeMode.StretchImage;
            BTN_Start.TabIndex = 3;
            BTN_Start.TabStop = false;
            BTN_Start.Click += BTN_Start_Click;
            // 
            // TB_Output
            // 
            TB_Output.Location = new Point(152, 293);
            TB_Output.Name = "TB_Output";
            TB_Output.PlaceholderText = "Ausgabe";
            TB_Output.Size = new Size(242, 27);
            TB_Output.TabIndex = 4;
            // 
            // TB_Input
            // 
            TB_Input.Location = new Point(152, 252);
            TB_Input.Name = "TB_Input";
            TB_Input.PlaceholderText = "Bitte Text oder Binärcode eingeben";
            TB_Input.Size = new Size(242, 27);
            TB_Input.TabIndex = 5;
            // 
            // TB_PathIn
            // 
            TB_PathIn.Location = new Point(434, 252);
            TB_PathIn.Name = "TB_PathIn";
            TB_PathIn.PlaceholderText = "Bitte den Werteschlüssel einfügen";
            TB_PathIn.Size = new Size(242, 27);
            TB_PathIn.TabIndex = 6;
            // 
            // TB_PathOut
            // 
            TB_PathOut.Location = new Point(434, 293);
            TB_PathOut.Name = "TB_PathOut";
            TB_PathOut.PlaceholderText = "Werteschlüssel";
            TB_PathOut.Size = new Size(242, 27);
            TB_PathOut.TabIndex = 7;
            // 
            // LBL_Eingabe
            // 
            LBL_Eingabe.AutoSize = true;
            LBL_Eingabe.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Eingabe.Location = new Point(22, 243);
            LBL_Eingabe.Name = "LBL_Eingabe";
            LBL_Eingabe.Size = new Size(104, 35);
            LBL_Eingabe.TabIndex = 8;
            LBL_Eingabe.Text = "Eingabe";
            // 
            // LBL_Ausgabe
            // 
            LBL_Ausgabe.AutoSize = true;
            LBL_Ausgabe.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Ausgabe.Location = new Point(22, 285);
            LBL_Ausgabe.Name = "LBL_Ausgabe";
            LBL_Ausgabe.Size = new Size(112, 35);
            LBL_Ausgabe.TabIndex = 9;
            LBL_Ausgabe.Text = "Ausgabe";
            // 
            // LBL_Titel
            // 
            LBL_Titel.AutoSize = true;
            LBL_Titel.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Titel.Location = new Point(300, 24);
            LBL_Titel.Name = "LBL_Titel";
            LBL_Titel.Size = new Size(155, 47);
            LBL_Titel.TabIndex = 10;
            LBL_Titel.Text = "Huffman";
            // 
            // button1
            // 
            button1.Location = new Point(400, 252);
            button1.Name = "button1";
            button1.Size = new Size(28, 26);
            button1.TabIndex = 11;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(682, 251);
            button2.Name = "button2";
            button2.Size = new Size(28, 29);
            button2.TabIndex = 12;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(400, 293);
            button3.Name = "button3";
            button3.Size = new Size(28, 29);
            button3.TabIndex = 13;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(682, 293);
            button4.Name = "button4";
            button4.Size = new Size(28, 29);
            button4.TabIndex = 14;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(684, 429);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Dark Mode";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Huffman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 507);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LBL_Titel);
            Controls.Add(LBL_Ausgabe);
            Controls.Add(LBL_Eingabe);
            Controls.Add(TB_PathOut);
            Controls.Add(TB_PathIn);
            Controls.Add(TB_Input);
            Controls.Add(TB_Output);
            Controls.Add(BTN_Start);
            Controls.Add(BTN_Back);
            Controls.Add(BTN_Help);
            Controls.Add(groupBox1);
            Name = "Huffman";
            Tag = "";
            Text = "Huffman";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BTN_Help).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Start).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton RB_Dekomprimieren;
        private RadioButton RB_Komprimieren;
        private PictureBox BTN_Help;
        private PictureBox BTN_Back;
        private PictureBox BTN_Start;
        private TextBox TB_Output;
        private TextBox TB_Input;
        private TextBox TB_PathIn;
        private TextBox TB_PathOut;
        private Label LBL_Eingabe;
        private Label LBL_Ausgabe;
        private Label LBL_Titel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
    }
}