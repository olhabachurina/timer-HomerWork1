namespace timer_HomerWork1
{

    public partial class Form1 : Form
    {
        bool format;
        int value = 1;
        public Form1()
        {
            InitializeComponent();
            format = false;
            StartTimer();

        }

        private void StartTimer()
        {
            timer1.Interval = value * 1000;
            timer1.Tick += Timer_Tick;
            timer1.Enabled = true;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            textBox1.Text = format ? DateTime.Now.ToString("hh:mm:ss") : DateTime.Now.ToString("HH:mm:ss");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            value = (int)numericUpDown1.Value;
            StartTimer();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            format = radioButton.Text.Equals("12");
        }
    }
}


