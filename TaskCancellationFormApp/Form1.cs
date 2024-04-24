using Microsoft.VisualBasic;

namespace TaskCancellationFormApp
{
    public partial class Form1 : Form
    {
        CancellationTokenSource ct = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {

            try
            {
                ct = new CancellationTokenSource();
                Task<HttpResponseMessage> myTask;

                myTask = new HttpClient().GetAsync("https://localhost:7225/api/Home\r\n", ct.Token);
                Task.Delay(5000);


                await myTask;
                var content = await myTask.Result.Content.ReadAsStringAsync();
                richTextBox1.Text = content;
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("Kurtlar vadisi operasyonu sona ermiþtir.");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ct.Cancel();

        }
    }
}
