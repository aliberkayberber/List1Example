List<string> davetliler = new List<string>(); // bir liste oluşturduk


davetliler.Add("Ajda Pekkan"); // listemize string elemanlar ekliyoruz
davetliler.Add("Hakan Ünal"); // listemize string elemanlar ekliyoruz
davetliler.Add("Bülent Ersoy"); // listemize string elemanlar ekliyoruz
davetliler.Add("Ebru Gündeş"); // listemize string elemanlar ekliyoruz
davetliler.Add("Hadise"); // listemize string elemanlar ekliyoruz
davetliler.Add("Demet Akalın"); // listemize string elemanlar ekliyoruz
davetliler.Add("Hande Yener"); // listemize string elemanlar ekliyoruz

System.Console.WriteLine("*****************     Davetliler   *****************");

for (int i = 0; i < davetliler.Count; i++)
{
    System.Console.WriteLine($"{i+1} ---> {davetliler[i]}"); // for ile liste ekrana yazılır
}

foreach (var item in davetliler)
{
    
    System.Console.WriteLine(item); // konsol ekranına listeyi yazdırıyor
}
