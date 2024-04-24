namespace ParalelForForEachCancellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        int counter = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            var urlList = new List<string>()
            {
                "https://google.com",
                "https://nakliyecim.net",
                "https://api.nakliyecim.net/api/user",

            };
            var total = 0;
            var client = new HttpClient();
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = cancellationTokenSource.Token;

            Task.Run(() =>
            {
                try
                {
                    Parallel.ForEach(urlList, parallelOptions, (url) =>
                    {
                        var str = client.GetStringAsync(url).Result;
                        cancellationTokenSource.Token.ThrowIfCancellationRequested();
                        rtbxTotal.Invoke((MethodInvoker)delegate { rtbxTotal.Text += $"\n{url}:{str.Length}"; });
                    });
                }
                catch (OperationCanceledException ex)
                {
                    MessageBox.Show("iþlem durduruldu");
                }
            });



            rtbxTotal.Text = total.ToString();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {

            btnCounter.Text = counter++.ToString();
        }
    }
}
