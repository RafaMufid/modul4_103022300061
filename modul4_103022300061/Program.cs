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

public class FanLaptop
{
    public enum State { Quiet, Balanced, Performanced, Turbo};
    public enum Trigger { ModeUp, ModeDown, TurboShortcut};
    public void Fan()
    {
        State state = State.Quiet;
        string[] fanState = { "Quiet", "Balanced", "Performanced", "Turbo" };

        Console.WriteLine("\n>>Kipas saat ini " + fanState[(int)state] + "\n");
        
    }
    public class Transition
    {
        public State stateAwal;
        public State stateAkhir;
        public Trigger trigger;

        public Transition(State stateAw, State stateAkh, Trigger trig)
        {
            stateAwal = stateAw;
            stateAkhir = stateAkh;
            trigger = trig;
        }

        Transition[] ubah =
        {
            new Transition(State.Quiet, State.Balanced, Trigger.ModeUp),
            new Transition(State.Quiet, State.Turbo, Trigger.TurboShortcut),
        };

        public State nextState(State stateAwal, Trigger trig)
        {
            foreach (var state in ubah)
            {
                if (stateAwal == state.stateAwal && trig == state.trigger)
                {
                    return state.stateAkhir;
                }
            }
            return stateAwal;
        }

        public void runTrigger(Trigger trig)
        {
            State stateSebelumnya = 
        }
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
