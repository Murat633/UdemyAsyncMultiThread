namespace TaskFormApp
{
    public partial class Form1 : Form
    {

        public int counter { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {            
            tbxCounter.Text = counter++.ToString();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            string data = await ReadFileAsync();
            
            tbxRead.Text = data;
        }



        private string ReadFile()
        {
            string data = string.Empty;
            using(StreamReader s = new StreamReader("test.txt"))
            {
                data = s.ReadToEnd();
                Thread.Sleep(5000);
            }
            return data;
        }


        private async Task<string> ReadFileAsync()
        {
            string data = string.Empty; 
            using(StreamReader s = new StreamReader("test.txt"))
            {
                data = await s.ReadToEndAsync();
            }
            await Task.Delay(5000);

            return await Task.FromResult(data);
        }
    }
}
