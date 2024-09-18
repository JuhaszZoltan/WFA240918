using System.Diagnostics;

namespace WFA240918
{
    public partial class FrmMain : Form
    {
        private static Random rnd = new();
        private Stopwatch stopwatch = new();
        private System.Windows.Forms.Timer timer = new();
        private bool isStart = false;

        public FrmMain()
        {
            InitializeComponent();
            btn.Click += Btn_Click;
            btn.MouseEnter += Btn_MouseEnter;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            lblGameTime.Text = 
                $"{stopwatch.Elapsed.Minutes:00}:" +
                $"{stopwatch.Elapsed.Seconds:00}:" +
                $"{stopwatch.Elapsed.Milliseconds:000}";
        }

        private void Btn_MouseEnter(object? sender, EventArgs e)
        {
            if (!isStart)
            {
                stopwatch.Start();
                timer.Start();
            }


            btn.Location = new(
                x: rnd.Next(pnl.Width - btn.Width),
                y: rnd.Next(pnl.Height - btn.Height));
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            stopwatch.Stop();
            timer.Stop();

            MessageBox.Show(
                caption: "YOU WIN!",
                text: $"elapsed time: {stopwatch.Elapsed.TotalSeconds:00.000} sec");
        }
    }
}
