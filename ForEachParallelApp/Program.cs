using System.Diagnostics;
using System.Drawing;



int total = 0;
Parallel.ForEach(Enumerable.Range(1, 100), () => 0, (x, loop, subtotal) =>
{
    Console.WriteLine("thread Id => " + Thread.CurrentThread.ManagedThreadId);   
    subtotal += x;
    return subtotal;
}, (y) =>Interlocked.Add(ref total, y));

Console.WriteLine(total);


//TLP .for metodu
//var filesPath = @"C:\\Users\\MHD\\source\\repos\\UdemyAsyncMultiThread\\ForEachParallelApp\\pictures\\";
//var totalByte = 0;
//var files = Directory.GetFiles(filesPath);

//Parallel.For(0, files.Length, index =>
//{
//    var file = files[index];
//    var image = new FileInfo(file);
//    Interlocked.Add(ref totalByte,(int)image.Length);
//});

//Console.WriteLine(totalByte);
// oluşan sorun örneği
//int deger = 0;

//Parallel.ForEach(Enumerable.Range(0, 100000).ToList(), (number) =>
//{
//    Interlocked.Add(ref deger, number);

//});

//Console.WriteLine(deger);


//interlocked sınıfı kullanımı
//var picturesPath = @"C:\Users\MHD\source\repos\UdemyAsyncMultiThread\ForEachParallelApp\pictures\";

//var files = Directory.GetFiles(picturesPath);

//long FilesByte = 0;

//Stopwatch sw = new Stopwatch();

//sw.Start();

//Parallel.ForEach(files, file =>
//{
//    //Console.WriteLine("Thread no:" + Thread.CurrentThread.ManagedThreadId);
//    Image img = new Bitmap(file);
//    var thumbnail = img.GetThumbnailImage(25, 25, () => false, IntPtr.Zero);
//    thumbnail.Save(Path.Combine(picturesPath, "thumbnail",Path.GetFileName(file)));


//    // 1. dosya 100byte
//    // 2. dosya 200byte
//    // 3. dosya 300byte
//    // 4. dosya 400byte
//    // 5. dosya 500byte

//    FileInfo f = new FileInfo(file);
//    Interlocked.Add(ref FilesByte,f.Length);
//});

//Console.WriteLine(FilesByte);

//sw.Stop();

//Console.WriteLine("işlem bitti "+sw.ElapsedMilliseconds);

