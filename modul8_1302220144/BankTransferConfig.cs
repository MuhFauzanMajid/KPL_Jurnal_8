using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_1302220144
{
     class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }
    }

     class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }
     class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }

     class TestConfig
    {

        public BankTransferConfig config;

        private const string file_path = "C:\\Kuliah\\Coding\\C#\\modul8_1302220144\\bank_transfer_config.json";

        public TestConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch
            {
                SetDefault();
                WriteConfigFile();
            }
        }

        public void ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(file_path);
            this.config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String text = JsonSerializer.Serialize(config);
            File.WriteAllText(file_path, text);
        }

        public void SetDefault()
        {
            config = new BankTransferConfig();
            Transfer transfer = new Transfer();
            Confirmation confirmation = new Confirmation(); 

            transfer.threshold = 25000000;
            transfer.low_fee = 6500;
            transfer.high_fee = 15000;

            confirmation.en = "yes";
            confirmation.id = "ya";
            
            config.lang = "en";
            config.transfer = transfer;
            config.methods = new List<String> { "RTO(real-time)", "SKN", "RTGS", "BI FAST" };
            config.confirmation = confirmation;
        }
    }
}

