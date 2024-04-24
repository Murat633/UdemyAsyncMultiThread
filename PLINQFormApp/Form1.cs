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
                    btnStart.Text = "Baþlatýlýyor...";
                    await Task.Delay(3000);
                    btnStart.Text = "Yeniden Baþlat";

                    var numbers = Enumerable.Range(1, 10).AsParallel().WithCancellation(ct.Token).ToList();
                    lbxNumbers.Items.Clear();
                    foreach (var item in numbers)
                    {
                        await Task.Delay(500);
                        ct.Token.ThrowIfCancellationRequested();
                        btnStart.Invoke(() => { btnStart.Text = "Yeniden Baþlat"; });
                        lbxNumbers.Items.Add(item);
                    }
                });
                btnStart.Text = "Baþlat";

            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show($"iþlem durduruldu: {ex.Message}");
                btnStart.Text = "Baþlat";

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
