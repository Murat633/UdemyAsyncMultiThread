namespace TaskThreadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Count = 0;

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            var aTask = Go(prgrssBar1);
            var bTask = Go(prgrssBar2);

            await Task.WhenAll(aTask, bTask);
        }

        public async Task Go(ProgressBar pb)
        {

            await Task.Run(() =>
            {
                Enumerable.Range(0, 100).ToList().ForEach(x =>
                {
                    Thread.Sleep(100);

                    // Bu eleman UI Thread içerisinde bulunmakta. fakat biz Farklý bir Thread kullandýðýmýz için UI Thread içerisindeki elemaný görmüyor aþþaðýdaki iþlem bu hatayý düzeltiyor.
                    pb.Invoke((MethodInvoker)delegate { pb.Value = x; });
                    //pb.Value = x;
                });
            });

        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            btnCounter.Text = Count++.ToString();
        }
    }
}
