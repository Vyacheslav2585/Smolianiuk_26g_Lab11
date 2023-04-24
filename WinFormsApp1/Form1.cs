namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte Operation;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeColor();
            textBox1.Text = "0";
            Operation = 0;
            this.BackColor = Color.FromArgb(64, 102, 139);
            this.ActiveControl = button10;

        }
        void plusTablo(char Symbol)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += Symbol.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            plusTablo('1'); ;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            plusTablo('2');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            plusTablo('3');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            plusTablo('4');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            plusTablo('5');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            plusTablo('6');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            plusTablo('7');
        }

        private void button19_Click(object sender, EventArgs e)
        {
            plusTablo('8');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            plusTablo('9');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            plusTablo('0');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool available = false;
            int i, len;
            len = textBox1.Text.Length;
            for (i = 0; i < len; i++)
                if (textBox1.Text[i].ToString() == ",")
                {
                    available = true;
                    break;
                }
            if (!available) textBox1.Text += ",";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int len = textBox1.Text.Length;
            textBox1.Text = textBox1.Text.Substring(0, len - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
        private void runOperation()
        {
            double Visual, Memory;
            if (Operation == 0) return;
            try
            {
                Visual = Convert.ToDouble(textBox1.Text);
                Memory = Convert.ToDouble(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Операцію виконати неможливо", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (Operation)
            {
                case 1:
                    Visual += Memory;
                    Memory = 0;
                    break;
                case 2:
                    Visual = Memory - Visual;
                    Memory = 0;
                    break;
                case 3:
                    Visual *= Memory;
                    Memory = 0;
                    break;
                case 4:
                    if (Visual == 0)
                    {
                        MessageBox.Show("Операція неможлива: ділення на нуль", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                    Visual = Memory / Visual;
                    Memory = 0;
                    break;
                case 5:
                    if (Visual < 0)
                    {
                        MessageBox.Show("Операція неможлива: корінь з від'ємного числа", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Visual = Math.Sqrt(Visual);
                    Memory = 0;
                    break;
                case 6:
                    Visual *= 0.01;
                    break;
                case 7:
                    if (Visual == 0)
                    {
                        MessageBox.Show("Операція неможлива: ділення на нуль", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Visual = 1 / Visual;
                    break;
                case 8:
                    Memory += Visual;
                    break;
                case 9:
                    Visual = 0;
                    break;
                case 10:
                    Memory = 0;
                    break;
                case 11:
                    Visual = Memory;
                    break;
                case 12:
                    Memory = Visual;
                    break;
                case 13:
                    Visual *= -1;
                    break;
                case 14:
                    Memory -= Visual;
                    break;
                case 15:
                    Visual -= Memory;
                    break;
            }
            Operation = 0;
            textBox1.Text = Visual.ToString();
            textBox2.Text = Memory.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int sqrt = Operation;
            Operation = 5;
            runOperation();
            Operation = (byte)sqrt;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            runOperation();
            Operation = 12;
            runOperation();
            Operation = 9;
            runOperation();
            Operation = 1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            runOperation();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            runOperation();
            Operation = 12;
            runOperation();
            Operation = 9;
            runOperation();
            Operation = 2;
        }
        public void changeColor()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {

                    ctrl.BackColor = Color.FromArgb(40, 45, 47);
                    ctrl.ForeColor = Color.FromArgb(255, 255, 255);
                    if (ctrl.Text == "=")
                    {
                        ctrl.BackColor = Color.OrangeRed;
                    }
                }
            }

        }
        private void button23_Click(object sender, EventArgs e)
        {
            runOperation();
            Operation = 12;
            runOperation();
            Operation = 9;
            runOperation();
            Operation = 3;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            runOperation();
            Operation = 12;
            runOperation();
            Operation = 9;
            runOperation();
            Operation = 4;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int sqrt = Operation;
            Operation = 7;
            runOperation();
            Operation = (byte)sqrt;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int sqrt = Operation;
            Operation = 6;
            runOperation();
            Operation = (byte)sqrt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation = 9;
            runOperation();
            Operation = 10;
            runOperation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sqrt = Operation;
            Operation = 11;
            runOperation();
            Operation = (byte)sqrt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sqrt = Operation;
            Operation = 10;
            runOperation();
            Operation = (byte)sqrt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sqrt = Operation;
            Operation = 14;
            runOperation();

            Operation = (byte)sqrt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sqrt = Operation;
            Operation = 8;
            runOperation();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int sqrt = Operation;
            Operation = 13;
            runOperation();
            Operation = (byte)sqrt;
        }
    }
}