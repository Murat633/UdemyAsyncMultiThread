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

                    // Bu eleman UI Thread i�erisinde bulunmakta. fakat biz Farkl� bir Thread kulland���m�z i�in UI Thread i�erisindeki eleman� g�rm�yor a��a��daki i�lem bu hatay� d�zeltiyor.
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
