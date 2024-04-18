using modul8_1302220144;

internal class Program
{
    private static void Main(string[] args)
    {
        TestConfig configtest = new TestConfig();

        if(configtest.config.lang == "en")
        {
            Console.Write("Please insert the amount of money to transfer : ");
        }
        else
        {
            Console.Write("Masukkan jumlah uang yang akan di-transfer : ");
        }
        int amount = Convert.ToInt32(Console.ReadLine());

        if(amount <= configtest.config.transfer.threshold)
        {
            if(configtest.config.lang == "en")
            {
                Console.WriteLine("Total amount = " + (amount+configtest.config.transfer.low_fee) );
            }
            else
            {
                Console.WriteLine("Total biaya = " + (amount + configtest.config.transfer.low_fee));
            }
        }else{
            if (configtest.config.lang == "en")
            {
                Console.WriteLine("Total amount = " + (amount + configtest.config.transfer.high_fee));
            }
            else
            {
                Console.WriteLine("Total biaya = " + (amount + configtest.config.transfer.high_fee));
            }
        }
        if(configtest.config.lang == "en")
        {
            Console.WriteLine("Select transfer method : ");
        }
        else
        {
            Console.WriteLine("pilih metode transfer : ");
        }
        
        for(int i = 0; i < configtest.config.methods.Count; i++)
        {
            Console.WriteLine((i+1) + ". " + configtest.config.methods[i]);
        }
        
        int method = Convert.ToInt32(Console.ReadLine());
        
        if(configtest.config.lang == "en")
        {
            Console.WriteLine("Please type " + configtest.config.confirmation.en + " to confirm the transaction");
        }
        else
        {
            Console.WriteLine("ketik " + configtest.config.confirmation.id + " untuk mengkonfirmasi transaksi");
        }
        
        string confirmation = Console.ReadLine();

        if (configtest.config.lang == "en")
        {
            if (confirmation == configtest.config.confirmation.en)
            {
                Console.WriteLine("Transaction is completed");
            }
            else
            {
                Console.WriteLine("Transaction is canceled");
            }
        }
        else if(configtest.config.lang == "id")
        {
            if (confirmation == configtest.config.confirmation.id)
            {
                Console.WriteLine("Proses transaksi berhasil");
            }
            else
            {
                Console.WriteLine("Transaksi dibatalkan");
            }
        }

    }
}