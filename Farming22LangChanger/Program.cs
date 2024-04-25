using System.Text.RegularExpressions;

namespace Farming22LangChanger {
    class Program {
        static void Main() {
            Console.Write("Write Farming Simulator 22 root folder path:"); string farmingPath = Console.ReadLine();
            Console.WriteLine("searching for Farming in " + farmingPath);

            try {
                if (Directory.Exists(farmingPath)) {
                Console.WriteLine("Directory found");
            }
            else {
                Console.WriteLine("ERROR: Cant find specified directory");
                Console.WriteLine("Press any key to try writing path again");
                Console.ReadLine();
                Main();
            }
            if (File.Exists(farmingPath + @"\x64\flt.ini")) {
                Console.WriteLine("flt.ini file found");
            }
            else {
                Console.WriteLine("ERROR: Cant find flt.ini file in " + farmingPath + @"\x64\flt.ini");
                Console.ReadLine();
            }
            }
            catch (Exception ex) {Console.WriteLine(ex.ToString());}

            if (Directory.Exists(farmingPath)) {
                Console.WriteLine("Directory found");
            }
            else {
                Console.WriteLine("ERROR: Cant find specified directory");
                Console.WriteLine("Press any key to try writing path again");
                Console.ReadLine();
                Main();
            }
            if (File.Exists(farmingPath + @"\x64\flt.ini")) {
                Console.WriteLine("flt.ini file found");
            }
            else {
                Console.WriteLine("ERROR: Cant find flt.ini file in " + farmingPath + @"\x64\flt.ini");
                Console.ReadLine();
            }
            
            Console.Clear();
            Console.WriteLine("1. English\n2. Czech\n3. French\n4. Italian\n5. German\n6. Danish\n7. Dutch\n 8. Finnish\n9. Hungarian\n10. Japanese \n11. Korean\n12. Polish");
            Console.WriteLine("13. Romanian\n14. Russian\n15. Swedish\n16. Turkish\n17. Norwegian");
            Console.WriteLine("Write number:");
            int ans = int.Parse(Console.ReadLine());
            string[] langs = {"","english", "czech", "french", "italian", "german","danish","dutch","finnish","hungarian","japanese","korean","polish","romanian","russian","swedish","turkish","norwegian"};
            string lang = langs[ans];

            string[] lines = File.ReadAllLines(farmingPath + @"\x64\flt.ini");
            int i = 0;
            while (true) {
                if (lines[i].Contains("Language=")) {
                    lines[i] = "Language=" + lang;
                    break;
                }
                else {
                    i++;
                }
            }
            File.WriteAllLines(farmingPath + @"\x64\flt.ini", lines);
            
        }
    }
}