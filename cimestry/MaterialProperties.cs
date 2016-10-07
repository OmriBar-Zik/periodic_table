using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimestry
{
    public class MaterialProperties
    {
        private int MaterialNumber;
        private string Materialsymbols;
        private string MaterialName;

        public MaterialProperties(int MaterialNumber, string Materialsymbols, string MaterialName)
        {
            this.MaterialNumber = MaterialNumber;
            this.Materialsymbols = Materialsymbols;
            this.MaterialName = MaterialName;
        }

        private static string PropertiesToString(int Mass, int AtomicNumber, string MaterialType)
        {
            string Tostring = "Mass: " + Mass.ToString() + "\n" + "AtomicNumber" + AtomicNumber.ToString() + "\n" + "Material Type: " + MaterialType;
            return Tostring;
        }

        public static string ArrangementOfElectrons(string Electrons)
        {
            List<int> EnergyLevels = new List<int>();
            int ElectronsNum = int.Parse(Electrons);
            if (ElectronsNum > 2)
            {
                if (ElectronsNum > 10)
                {
                    if (ElectronsNum > 18)
                    {
                        ElectronsNum -= 8;
                        EnergyLevels.Insert(0, 8);
                    }
                    ElectronsNum -= 8;
                    EnergyLevels.Insert(0, 8);
                }
                ElectronsNum -= 2;
                EnergyLevels.Insert(0, 2);
            }
            EnergyLevels.Add(ElectronsNum);
            return string.Join(",",EnergyLevels);

        }

        public string GetMaterialNumberString() { return this.MaterialNumber.ToString(); }
        public int GetMaterialNumberInt() { return this.MaterialNumber; }
        public string GetMaterialsymbols() { return this.Materialsymbols; }
        public string GetMaterialName() { return this.MaterialName; }

        public static void YAY()
        {
            Console.WriteLine(@"                                          `-.`'.-'");
            Console.WriteLine(@"                                       `-.        .-'.");
            Console.WriteLine(@"                                    `-.    -./\.-    .-'");
            Console.WriteLine(@"                                        -.  /_|\  .-");
            Console.WriteLine(@"                                    `-.   `/____\'   .-'.");
            Console.WriteLine(@"                                 `-.    -./.-""-.\.-      '");
            Console.WriteLine(@"                                    `-.  /< (()) >\  .-'");
            Console.WriteLine(@"                                  -   .`/__`-..-'__\'   .-");
            Console.WriteLine(@"                                ,...`-./___|____|___\.-'.,.");
            Console.WriteLine(@"                                   ,-'   ,` . . ',   `-,");
            Console.WriteLine(@"                                ,-'   ________________  `-,");
            Console.WriteLine(@"                                   ,'/____|_____|_____\");
            Console.WriteLine(@"                                  / /__|_____|_____|___\");
            Console.WriteLine(@"                                 / /|_____|_____|_____|_\");
            Console.WriteLine(@"                                ' /____|_____|_____|_____\");
            Console.WriteLine(@"                              .' /__|_____|_____|_____|___\");
            Console.WriteLine(@"                             ,' /|_____|_____|_____|_____|_\");
            Console.WriteLine(@",,---''--...___...--'''--.. /../____|_____|_____|_____|_____\ ..--```--...___...--``---,,");
            /*
            Console.WriteLine(@"                           '../__|_____|_____|_____|_____|___\");
            Console.WriteLine(@"      \    )              '.:/|_____|_____|_____|_____|_____|_\               (    /");
            Console.WriteLine(@"      )\  / )           ,':./____|_____|_____|_____|_____|_____\             ( \  /(");
            Console.WriteLine(@"     / / ( (           /:../__|_____|_____|_____|_____|_____|___\             ) ) \ \");
            Console.WriteLine(@"    | |   \ \         /.../|_____|_____|_____|_____|_____|_____|_\           / /   | |");
            Console.WriteLine(@" .-.\ \    \ \       '..:/____|_____|_____|_____|_____|_____|_____\         / /    / /.-.");
            Console.WriteLine(@"(=  )\ `._.' |       \:./ _  _ ___  ____ ____ _    _ _ _ _ _  _ ___\        | `._.' /(  =)");
            Console.WriteLine(@" \ (_)       )       \./  |\/| |__) |___ |___ |___ _X_ _X_  \/  _|_ \       (       (_) /");
            Console.WriteLine(@"  \    `----'         """"""""""""""""""""""""""""""""""""""""""""""""       `----'    /");
            Console.WriteLine(@"   \   ____\__          __ __    _  __ _     _  __ ________    _____        __/____   /");
            Console.WriteLine(@"    \ (=\     \        (_ |_ |V||_)|_ |_)   |_|(_ /   |  |    |_  |        /     /-) /");
            Console.WriteLine(@"     \_)_\     \       __)|__| ||  |__| \   | |__)\___|__|_   |  _|_      /     /_(_/");
            Console.WriteLine(@"          \     \                                                        /     /");
            Console.WriteLine(@"           )     )  _                                                _  (     (");
            Console.WriteLine(@"          (     (,-' `-..__                                    __..-' `-,)     )");
            Console.WriteLine(@"           \_.-''          ``-..____                  ____..-''          ``-._/");
            Console.WriteLine(@"            `-._                    ``--...____...--''                    _.-'");
            Console.WriteLine(@"                `-.._                                                _..-'");
            Console.WriteLine(@"                     `-..__          ALT.ASCII-ART             __..-'");
            Console.WriteLine(@"                           ``-..____                  ____..-''");
            Console.WriteLine(@"                                    ``--...____...--''");
        */
        }

    }
}
