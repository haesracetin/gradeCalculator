namespace WinFormsApp1
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
            label1 = new Label();
            SelectLecture = new ComboBox();
            midtermTextbox = new TextBox();
            finalTextbox = new TextBox();
            quiz1Textbox = new TextBox();
            midtermRate = new TextBox();
            finalRate = new TextBox();
            quiz1Rate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            quiz2Textbox = new TextBox();
            quiz2Rate = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            calcuteButton = new Button();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            resultTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(370, 68);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "GRADE CALCULATOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // SelectLecture
            // 
            SelectLecture.FormattingEnabled = true;
            SelectLecture.Location = new Point(151, 178);
            SelectLecture.Name = "SelectLecture";
            SelectLecture.Size = new Size(151, 28);
            SelectLecture.TabIndex = 1;
            SelectLecture.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // midtermTextbox
            // 
            midtermTextbox.Location = new Point(151, 227);
            midtermTextbox.Name = "midtermTextbox";
            midtermTextbox.Size = new Size(125, 27);
            midtermTextbox.TabIndex = 2;
            midtermTextbox.TextChanged += textBox1_TextChanged;
            // 
            // finalTextbox
            // 
            finalTextbox.Location = new Point(151, 282);
            finalTextbox.Name = "finalTextbox";
            finalTextbox.Size = new Size(125, 27);
            finalTextbox.TabIndex = 3;
            // 
            // quiz1Textbox
            // 
            quiz1Textbox.Location = new Point(151, 333);
            quiz1Textbox.Name = "quiz1Textbox";
            quiz1Textbox.Size = new Size(125, 27);
            quiz1Textbox.TabIndex = 4;
            // 
            // midtermRate
            // 
            midtermRate.Location = new Point(507, 227);
            midtermRate.Name = "midtermRate";
            midtermRate.Size = new Size(125, 27);
            midtermRate.TabIndex = 5;
            // 
            // finalRate
            // 
            finalRate.Location = new Point(507, 282);
            finalRate.Name = "finalRate";
            finalRate.Size = new Size(125, 27);
            finalRate.TabIndex = 6;
            // 
            // quiz1Rate
            // 
            quiz1Rate.Location = new Point(507, 333);
            quiz1Rate.Name = "quiz1Rate";
            quiz1Rate.Size = new Size(125, 27);
            quiz1Rate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 234);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Midterm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 289);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 9;
            label3.Text = "Final:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 336);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "Quiz1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 383);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Quiz2:";
            // 
            // quiz2Textbox
            // 
            quiz2Textbox.Location = new Point(151, 380);
            quiz2Textbox.Name = "quiz2Textbox";
            quiz2Textbox.Size = new Size(125, 27);
            quiz2Textbox.TabIndex = 12;
            // 
            // quiz2Rate
            // 
            quiz2Rate.Location = new Point(507, 383);
            quiz2Rate.Name = "quiz2Rate";
            quiz2Rate.Size = new Size(125, 27);
            quiz2Rate.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 178);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 15;
            label7.Text = "Lecture:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 230);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 16;
            label8.Text = "Rate (percentage):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 282);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 17;
            label9.Text = "Rate (percentage):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(370, 333);
            label10.Name = "label10";
            label10.Size = new Size(131, 20);
            label10.TabIndex = 18;
            label10.Text = "Rate (percentage):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(370, 380);
            label11.Name = "label11";
            label11.Size = new Size(131, 20);
            label11.TabIndex = 19;
            label11.Text = "Rate (percentage):";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.calculator_floating_cartoon_vector_icon_illustration_finance_business_icon_concept_isolated_flat_138;
            pictureBox1.Location = new Point(786, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // calcuteButton
            // 
            calcuteButton.BackColor = Color.Peru;
            calcuteButton.Location = new Point(440, 485);
            calcuteButton.Name = "calcuteButton";
            calcuteButton.Size = new Size(110, 43);
            calcuteButton.TabIndex = 21;
            calcuteButton.Text = "Calculate";
            calcuteButton.UseVisualStyleBackColor = false;
            calcuteButton.Click += calcuteButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.images;
            pictureBox2.Location = new Point(30, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(816, 253);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 23;
            label6.Text = "Result";
            // 
            // resultTextbox
            // 
            resultTextbox.Location = new Point(785, 289);
            resultTextbox.Name = "resultTextbox";
            resultTextbox.Size = new Size(125, 27);
            resultTextbox.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(942, 573);
            Controls.Add(resultTextbox);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(calcuteButton);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(quiz2Rate);
            Controls.Add(quiz2Textbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(quiz1Rate);
            Controls.Add(finalRate);
            Controls.Add(midtermRate);
            Controls.Add(quiz1Textbox);
            Controls.Add(finalTextbox);
            Controls.Add(midtermTextbox);
            Controls.Add(SelectLecture);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox SelectLecture;
        private TextBox midtermTextbox;
        private TextBox finalTextbox;
        private TextBox quiz1Textbox;
        private TextBox midtermRate;
        private TextBox finalRate;
        private TextBox quiz1Rate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox quiz2Textbox;
        private TextBox quiz2Rate;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private Button calcuteButton;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox resultTextbox;
    }
}
