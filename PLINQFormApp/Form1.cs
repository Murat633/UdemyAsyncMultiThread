namespace PLINQFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CancellationTokenSource ct = new CancellationTokenSource();

        private async void btnStart_Click(object sender, EventArgs e)
        {                
            try
            {
                await Task.Run(async () =>
                {
                    
                    ct.Cancel();
                    await Task.Delay(1000);
                    ct = new CancellationTokenSource();
                    btnStart.Text = "Ba�lat�l�yor...";
                    await Task.Delay(3000);
                    btnStart.Text = "Yeniden Ba�lat";

                    var numbers = Enumerable.Range(1, 10).AsParallel().WithCancellation(ct.Token).ToList();
                    lbxNumbers.Items.Clear();
                    foreach (var item in numbers)
                    {
                        await Task.Delay(500);
                        ct.Token.ThrowIfCancellationRequested();
                        btnStart.Invoke(() => { btnStart.Text = "Yeniden Ba�lat"; });
                        lbxNumbers.Items.Add(item);
                    }
                });
                btnStart.Text = "Ba�lat";

            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show($"i�lem durduruldu: {ex.Message}");
                btnStart.Text = "Ba�lat";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ct.Cancel();
        }
    }
}
