// See https://aka.ms/new-console-template for more information
public class KodeProduk
{
    public static string getKodeProduk(string produk)
    {
        string[,] dataProduk =
        {
            {"Laptop", "E100"},
            {"Smartphone", "E101"},
            {"Tablet", "E102"},
            {"Headset", "E103"},
            {"Keyboard", "E104"},
            {"Mouse", "E105"},
            {"Printer", "E106"},
            {"Monitor", "E107"},
            {"Smartwatch", "E108"},
            {"Kamera", "E109"}
        };
        
        for (int i = 0; i < dataProduk.GetLength(0); i++)
        {
            if (dataProduk[i, 0].Equals(produk, StringComparison.OrdinalIgnoreCase))
            {
                return dataProduk[i, 1];
            }
        }
        return "Produk tidak ditemukan";
    }
}

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Masukkan nama produk elektronik: ");
        string produkElektronik = Console.ReadLine() ?? "";

        string kodeProduk = KodeProduk.getKodeProduk(produkElektronik);
        Console.WriteLine($"Kode Produk {produkElektronik} : {kodeProduk}");
    }
}
