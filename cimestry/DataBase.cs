using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimestry
{
    class DataBase
    {
        //public string[][] MaterialsInformtion = new string[20][];
        public string[][] MaterialsInformtion = 
        {
            new string[] { "1", "H", "Hydrogen", "Nonmetal","2.1" },
            new string[] { "2", "He", "Helium", "Noble Gases" ,"-"},
            new string[] { "3", "Li", "Lithium", "Alkali Metals" ,"1.0"},
            new string[] { "4", "Be", "Beryllium", "Alkaline-earth metals","1.5" },
            new string[] { "5", "B", "Boron", "Semi-metals", "2.0"},
            new string[] { "6", "C", "Carbon", "Nonmetal" ,"2.5"},
            new string[] { "7", "N", "Nitrogen", "Nonmetal" ,"3.0"},
            new string[] { "8", "O", "Oxygen", "Nonmetal" ,"3.5"},
            new string[] { "9", "F", "fluorine", "Halogen" ,"4.0"},
            new string[] { "10", "Ne", "Neon", "Noble Gases" ,"-"},
            new string[] { "11", "Na", "Sodium", "Alkali Metals" ,"0.9"},
            new string[] { "12", "Mg", "Magnesium", "Alkaline-earth metals","1.2" },
            new string[] { "13", "Al", "Aluminium", "Metals","1.5" },
            new string[] { "14", "Si", "Silicon", "Semi-metals" ,"1.8"},
            new string[] { "15", "P", "Phosphorus", "Nonmetal" ,"2.1"},
            new string[] { "16", "S", "Sulfur", "Nonmetal","2.5" },
            new string[] { "17", "Cl", "Chlorine", "Halogen" ,"3.0"},
            new string[] { "18", "Ar", "Argon", "Noble Gases" ,"-"},
            new string[] { "19", "K", "Potassium", "Alkali Metals" ,"0.8"},
            new string[] { "20", "Ca", "Calcium", "Alkaline-earth metals","1.0" }
        };

        public string[] KeyWord = { "skip", "name", "number", "symbol", "type", "all", "configuration", "electronegativity" };

        public KeyValuePair<int, string>[] test = new KeyValuePair<int, string>[2];

        public char[] SpecialCharacters = { '?', ';', ',' ,'.'};

        public DataBase()
        {
/*
            MaterialsInformtion[0] = new string[] { "1", "H", "Hydrogen", "Nonmetal" };
            MaterialsInformtion[1] = new string[] { "2", "He", "Helium", "Noble Gases" };
            MaterialsInformtion[2] = new string[] { "3", "Li", "Lithium", "Alkali Metals" };
            MaterialsInformtion[3] = new string[] { "4", "Be", "Beryllium", "Alkaline-earth metals" };
            MaterialsInformtion[4] = new string[] { "5", "B", "Boron", "Semi-metals" };
            MaterialsInformtion[5] = new string[] { "6", "C", "Carbon", "Nonmetal" };
            MaterialsInformtion[6] = new string[] { "7", "N", "Nitrogen", "Nonmetal" };
            MaterialsInformtion[7] = new string[] { "8", "O", "Oxygen", "Nonmetal" };
            MaterialsInformtion[8] = new string[] { "9", "F", "fluorine", "Halogen" };
            MaterialsInformtion[9] = new string[] { "10", "Ne", "Neon", "Noble Gases" };
            MaterialsInformtion[10] = new string[] { "11", "Na", "Sodium", "Alkali Metals" };
            MaterialsInformtion[11] = new string[] { "12", "Mg", "Magnesium", "Alkaline-earth metals" };
            MaterialsInformtion[12] = new string[] { "13", "Al", "Aluminium", "Metals" };
            MaterialsInformtion[13] = new string[] { "14", "Si", "Silicon", "Semi-metals" };
            MaterialsInformtion[14] = new string[] { "15", "P", "Phosphorus", "Nonmetal" };
            MaterialsInformtion[15] = new string[] { "16", "S", "Sulfur", "Nonmetal" };
            MaterialsInformtion[16] = new string[] { "17", "Cl", "Chlorine", "Halogen" };
            MaterialsInformtion[17] = new string[] { "18", "Ar", "Argon", "Noble Gases" };
            MaterialsInformtion[18] = new string[] { "19", "K", "Potassium", "Alkali Metals" };
            MaterialsInformtion[19] = new string[] { "20", "Ca", "Calcium", "Alkaline-earth metals" };
*/
            
        }
    }
}
