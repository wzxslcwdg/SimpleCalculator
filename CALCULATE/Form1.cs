namespace Calculate
{
    public partial class Form1 : Form
    {
        double number1 = 0, number2 = 0,number3=0;
        int inputnumber;

        enum Operator { none, plus, minus, multiply, division }
        Operator mode = Operator.none;
        bool ismode = false;
        bool isplus = false;
        bool isminus = false;
        bool ismult = false;
        bool isdivi = false;


        public Form1()
        {
            InitializeComponent();
        }



        private void button16_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            number3 = 0;
            isminus = false;
            ismult = false;
            isdivi = false;
            isplus = false;
            ismode = false;


            labelout.Text = Convert.ToString(number2);
        }
        private void plus_Click(object sender, EventArgs e)
        {

            mode = Operator.plus;

            labelmode.Text = "+";
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            ismode = true;
            isplus = true;

        }
        private void minus_Click(object sender, EventArgs e)
        {
            mode = Operator.minus;

            labelmode.Text = "-";
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            ismode = true;
            isminus = true;
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            mode = Operator.multiply;

            labelmode.Text = "*";
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            ismode = true;
            ismult = true;
        }
        private void division_Click(object sender, EventArgs e)
        {
            mode = Operator.division;

            labelmode.Text = "/";
            labelout.Text = Convert.ToString(number2);
            labelbefore.Text = Convert.ToString(number1);
            ismode = true;
            isdivi = true;
        }



        private void button10_Click(object sender, EventArgs e)
        {
            inputnumber = 0;
            Calculate(inputnumber);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputnumber = 9;
            Calculate(inputnumber);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputnumber = 8;
            Calculate(inputnumber);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputnumber = 7;
            Calculate(inputnumber);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputnumber = 6;
            Calculate(inputnumber);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputnumber = 5;
            Calculate(inputnumber);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputnumber = 4;
            Calculate(inputnumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputnumber = 3;
            Calculate(inputnumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputnumber = 2;
            Calculate(inputnumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputnumber = 1;
            Calculate(inputnumber);
        }
        public void Calculate(int ck)
        {
            if (ismode == false)
            {
                number1 = number1 * 10 + ck;
                labelout.Text = Convert.ToString(number1);
            }
            else
            {
                number2 = number2 * 10 + ck;
                labelout.Text = Convert.ToString(number2);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelout.Text = Convert.ToString(number1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isplus == true)
            {
                number3 = number1 + number2;
                labelbefore.Text = Convert.ToString("");
                labelmode.Text = Convert.ToString("");
                labelout.Text = Convert.ToString(number3);
                number1 = number3;
                number2 = 0;
                number3 = 0;
                isplus = false;
                ismode = false;
            }
            else if (isminus == true)
            {
                number3 = number1 - number2;
                labelbefore.Text = Convert.ToString("");
                labelmode.Text = Convert.ToString("");
                labelout.Text = Convert.ToString(number3);
                number1 = number3;
                number2 = 0;
                number3 = 0;
                isminus = false;
                ismode = false;
            }
            else if (ismult == true)
            {
                number3 = number1 * number2;
                labelbefore.Text = Convert.ToString("");
                labelmode.Text = Convert.ToString("");
                labelout.Text = Convert.ToString(number3);
                number1 = number3;
                number2 = 0;
                number3 = 0;
                ismult = false;
                ismode = false;
            }
            else if (isdivi == true && number2!=0)
            {
                number3 = number1 / number2;
                labelbefore.Text = Convert.ToString("");
                labelmode.Text = Convert.ToString("");
                labelout.Text = Convert.ToString(number3);
                number1 = number3;
                number2 = 0;
                number3 = 0;

                isdivi = false;
                ismode = false;
            }
            else if (isdivi == true && number2 == 0)
            {
                labelbefore.Text = Convert.ToString("");
                labelmode.Text = Convert.ToString("");
                labelout.Text = Convert.ToString("error");
                number1 = 0;
                number2 = 0;
                isdivi = false;
                ismode = false;

            }

        }
    }
}