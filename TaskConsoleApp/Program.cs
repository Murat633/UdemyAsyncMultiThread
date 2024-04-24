


var cacheData = "";

Task<string> GetDataAsync()
{
    if (string.IsNullOrEmpty(cacheData))
    {
        return File.ReadAllTextAsync("dosya.txt");
    }else
    {
        return Task.FromResult(cacheData);
    }
}


cacheData = await GetDataAsync();

Console.WriteLine(cacheData);





































//Startnew() method örneği
//var myTask =  Task.Factory.StartNew(
//    (Obj) => {
//        Console.WriteLine("MyTask çalıştı");
//        var status = Obj as Status;
//        status.ThreadId = Thread.CurrentThread.ManagedThreadId;
//    }, 
//    new Status() { Date = DateTime.Now }
// );


//await myTask;

//Status s = myTask.AsyncState as Status;

//Console.WriteLine(s.Date);
//Console.WriteLine(s.ThreadId);

//public class Status
//{
//    public int ThreadId { get; set; }
//    public DateTime Date { get; set; }
//}















//******** 2. bölüm ******** //
//Console.WriteLine("main thread: " + Thread.CurrentThread.ManagedThreadId);
//static async Task<Content> GetContentAsync(string url)
//{
//    Content c = new Content();
//    var data = await new HttpClient().GetStringAsync(url);

//    c.Site = url;
//    c.Length = data.Length;

//    Task.Delay(5000);

//    Console.WriteLine("getContent Thread: " + Thread.CurrentThread.ManagedThreadId);
//    return c;
//};

//List<string> UrlsList = new List<string>()
//{
//    "https://www.google.com",
//    "https://www.amazon.com",
//    "https://www.n11.com",
//    "https://www.haberturk.com"
//};


//List<Task<Content>> taskList = new List<Task<Content>>();

//foreach (string url in UrlsList)
//{
//    var task = GetContentAsync(url);
//    taskList.Add(task);
//}

//Console.WriteLine("waitAll öncesi");
//var contents =  Task.WhenAll(taskList.ToArray());
//Console.WriteLine("ilk gelen değer: " + contents.First().Site);

//var allContentsTasks = await contents;

//Console.WriteLine(taskList.First().Result.Site);

////var content = Task.WhenAny(taskList.ToArray());
//////Console.WriteLine(content);
////var firstContent = await content;

//public class Content
//{
//    public string Site { get; set; }
//    public int Length { get; set; }
//};













//' countinuewith() '
//await new HttpClient().GetStringAsync("https://www.google.com").ContinueWith(
//    (data) =>
//    {
//        Console.WriteLine("data uzunluk:" + data.Result.Length);
//    }
//);

//Console.WriteLine("arada yapılcak");
////await myTask;