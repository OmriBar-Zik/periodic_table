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

        public static List<int> ArrangementOfElectrons(string Electrons)
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
            return EnergyLevels;

        }

        public string GetMaterialNumberString() { return this.MaterialNumber.ToString(); }
        public int GetMaterialNumberInt() { return this.MaterialNumber; }
        public string GetMaterialsymbols() { return this.Materialsymbols; }
        public string GetMaterialName() { return this.MaterialName; }

    }
}
