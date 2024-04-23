using NPOI.SS.Formula.PTG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackDataSince
{
    internal class DataBase
    {
        int ID;
        string Name;
        string IsNetObject;
        string Type;
        string AdmArea;
        string District;
        int SeatCounts;
        public DataBase()
        {
        }

        public DataBase(int iD, string name, string isNetObject, string type, string admArea, string district,int seatCounts)
        {
            ID = iD;
            Name = name;
            IsNetObject = isNetObject;
            Type = type;
            AdmArea = admArea;
            District = district;
            SeatCounts = seatCounts;
        }
        public string admArea { get => AdmArea; }
        public int seatCounts{ get => SeatCounts; }
        public string type { get => Type; }
        public void show()
        {
            Console.Write(ID + "  ");
            Console.Write(Name + "  ");
            Console.Write(IsNetObject + "  ");
            Console.Write(Type + "  ");
            Console.Write(AdmArea + "  ");
            Console.Write(District + "  ");
            Console.WriteLine();
        }
    }
}
