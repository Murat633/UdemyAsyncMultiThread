//.WithDegreeOfParallelism(10) birden fazla işlemcinin kullanılmasını sağlar
//forAll Parallel bir döngü oluşturur.
//.AsParallel() diziyi parallel nesneye çevirerek paralel(Multi-Thread) işlemler yapmamızı sağlar.

/* 
.AsOrdered() veritabanından gelen veriyi sırasını bozmadan listelememize yarar. 
Parallel çalıştırdığımız için dizilerin içerikleri farklı Thread'ler içerisinde çalıştığından dolayı
farklı sürelerde işlemleri sürdürüldüğünden dolayı sıralama bozula biliyor. 
*/

/*
    .WithExecutionMode(ParallelExecutionMode.ForceParallelism) bu modu aktif 
    ettiğimizde Parallel sorgularımız LINQ Algoritmasına göre parallel veya normal bir 
    çalışma göstermesini engeller ve direkt ne olursa olsun parallel çalışmasını sağlar.
*/

using PLINQAPP.Models;

var context = new Addamsfa1AkContext();


//var categories = (from c in context.Categories.AsParallel()
//               where c.Id > 0
//               select c).Take(10);

var categories = context.Categories.ToArray();

categories[3].Name = "££";
categories[4].Name = "££";

bool IsControl(Category category)
{
    try
    {
        return category.Name[2] == 'd';
    }
    catch(Exception ex)
    {
        Console.WriteLine("Hata F: "+ex.Message);
        return false;
    }
}
var cancellationToken = new CancellationTokenSource();
try
{
    cancellationToken = new CancellationTokenSource();
    //cancellationToken.Cancel();
    //var option = new ParallelOptions();
    //option.CancellationToken = cancellationToken.Token;
    cancellationToken.Cancel();

    var query = categories.AsParallel().Where(IsControl);
        cancellationToken.Token.ThrowIfCancellationRequested();
    query.ForAll(x =>
    {        
        Console.WriteLine(x.Name);
    });
}
catch(AggregateException ex)
{
    ex.InnerExceptions.ToList().ForEach(x =>
    {
        Console.WriteLine("hata: "+x.GetType().Name);
    });
}catch(OperationCanceledException canceledEx)
{
    Console.WriteLine("Listeleme iptal edildi.");
}

//var categories = context.Categories.AsParallel();

//categories.ForAll(x =>
//{
//    Console.WriteLine(x.Name);
//});








//var array = Enumerable.Range(0, 10);

//bool Islem(int x)
//{
//    return x % 2 == 0;
//}

//var newArray = array.AsParallel().Where(Islem);

//void cwFunc(int x){
//    Thread.Sleep(500);
//    Console.WriteLine(x);
//};

//newArray.ToList().ForEach(cwFunc);
//Console.WriteLine("--------------------------");
//newArray.ForAll(cwFunc);