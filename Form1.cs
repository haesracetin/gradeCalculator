namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectLecture.Items.Add("Network");
            SelectLecture.Items.Add("Visual Programming");
            SelectLecture.Items.Add("Microprocessor");
            SelectLecture.Items.Add("Robotics");
            SelectLecture.Items.Add("Numceric Analysis");
            SelectLecture.Items.Add("Operating System");
            SelectLecture.Items.Add("Introduction to computer engineering");
            SelectLecture.Items.Add("Introduction to programming language");
            SelectLecture.Items.Add("Logic Circuit");
            SelectLecture.Items.Add("Electronics");
            SelectLecture.Items.Add("Data Structure");
            SelectLecture.Items.Add("Algorithm");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void calcuteButton_Click(object sender, EventArgs e)
        {
            if (quiz1Textbox.TextLength > 0 && quiz2Textbox.TextLength > 0)
            {
                float quiz1 = Convert.ToSingle(quiz1Textbox.Text);
                float quiz2 = Convert.ToSingle(quiz2Textbox.Text);
                float midterm = Convert.ToSingle(midtermTextbox.Text);
                float final = Convert.ToSingle(finalTextbox.Text);
                float midtermrate = Convert.ToSingle(midtermRate.Text);
                float finalrate = Convert.ToSingle(finalRate.Text);
                float quiz1rate = Convert.ToSingle(quiz1Rate.Text);
                float quiz2rate = Convert.ToSingle(quiz2Rate.Text);
                if(midtermrate + finalrate + quiz1rate + quiz2rate == 100)
                {
                    float result = (midterm * midtermrate +
                               final * finalrate  +
                               quiz1 * quiz1rate  +
                               quiz2 * quiz2rate );
                    result = result / 100;

                    resultTextbox.Text = result.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Please check the percentage values (total must be 100).");
                }

                
            }
            else if(quiz1Textbox.TextLength > 0 && quiz2Textbox.TextLength == 0)
            {
                float quiz1 = Convert.ToSingle(quiz1Textbox.Text);
                float midterm = Convert.ToSingle(midtermTextbox.Text);
                float final = Convert.ToSingle(finalTextbox.Text);
                float midtermrate = Convert.ToSingle(midtermRate.Text);
                float finalrate = Convert.ToSingle(finalRate.Text);
                float quiz1rate = Convert.ToSingle(quiz1Rate.Text);
                if (midtermrate + finalrate + quiz1rate  == 100)
                {
                    float result = (midterm * midtermrate +
                               final * finalrate  +
                               quiz1 * quiz1rate );
                               result = result / 100;

                    resultTextbox.Text = result.ToString("F2");

                }
                else 
                {
                    MessageBox.Show("Please check the percentage values (total must be 100).");
                }

            }
            else
            {
               
                float midterm = Convert.ToSingle(midtermTextbox.Text);
                float final = Convert.ToSingle(finalTextbox.Text);
                float midtermrate = Convert.ToSingle(midtermRate.Text);
                float finalrate = Convert.ToSingle(finalRate.Text);
                if (midtermrate + finalrate == 100)
                {
                    float result = (midterm * midtermrate  +
                    final * finalrate );
                    result = result / 100;


                    resultTextbox.Text = result.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Please check the percentage values (total must be 100).");
                }



            }
            
        }
    }
}
