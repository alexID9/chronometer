using System.Diagnostics.Eventing.Reader;

namespace chronometer
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartTimer(object sender, EventArgs e)
        {
            chronometer.Start();
        }
        private void StopTimer(object sender, EventArgs e)
        {
            chronometer.Stop();
        }
        private void RestartTimer(object sender, EventArgs e)
        {
            timerlbl.Text = "00:00";
            counter = 0;
        }
        private int getMin()
        {
            return counter / 60;
        }
        private int getSec()
        {
            return counter % 60;
        }
        private string formatTime(string var)
        {
            if(var.Length < 2) {return ("0" + var);} else { return  var;}
        }
        private void Ticking(object sender, EventArgs e)
        {
            counter ++;
            string count = formatTime(Convert.ToString(getMin())) + ":" + formatTime(Convert.ToString(getSec()));
            timerlbl.Text = count;
        }
    }
}