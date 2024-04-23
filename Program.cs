using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.IO;
using System;
using System.Collections.Generic;
using HackDataSince;

internal class Program
{
    public static void show(List<DataBase> datas)
    {
        foreach (DataBase i in datas)
            i.show();
    }
    static public int findAreaCount(ref List<DataBase> datas,string type)
    {
        int count = 0;
        foreach(DataBase i in datas)
        {
            if (i.type == type)
                count += i.seatCounts; 
        }
        return count;
    }

    private static void Main(string[] args)
    {
        int ID;
        string Name;
        string IsNetObject;
        string Type;
        string AdmArea;
        int District;
        // Для .xlsx файла
        IWorkbook workbook;
        using (FileStream file = new FileStream(@"C:\Users\ATPIX\Desktop\HMF_24_dataset_sch.xlsx", FileMode.Open, FileAccess.Read))
        {
            workbook = new XSSFWorkbook(file);
        }


        ISheet sheet = workbook.GetSheetAt(0);
        IRow row = sheet.GetRow(2);
        ICell cell = row.GetCell(4);
        var value = cell.StringCellValue;
        List<DataBase> datas = new List<DataBase> { };
        for (int i = 2; i < 20857; i++)
        {

            //sheet = workbook.GetSheetAt(0);
            row = sheet.GetRow(i);
            cell = row.GetCell(5);
            value = cell.StringCellValue;
            //Console.WriteLine(Convert.ToString(value) + "-" + Convert.ToString(i));
            ID = i;
            cell = row.GetCell(0);
            Name = cell.StringCellValue;
            cell = row.GetCell(1);
            IsNetObject = cell.StringCellValue;
            cell = row.GetCell(3);
            Type = cell.StringCellValue;
            cell = row.GetCell(4);
            AdmArea = cell.StringCellValue;
            cell = row.GetCell(8);
            District = Convert.ToInt32(cell.StringCellValue);
            datas.Add(new DataBase(ID, Name, IsNetObject, Type, AdmArea, value,District));


        }
        
        Console.WriteLine();
        //show(datas);
        Console.WriteLine();
        Console.WriteLine(findAreaCount(ref datas, "кафетерий"));
        Console.ReadLine();
    }
}