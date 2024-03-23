// See https://aka.ms/new-console-template for more information

using modul5_1302223119;


Console.WriteLine("Generic method:");
Penjumlahan.JumlahTigaAngka<long>(13, 02, 22);


Console.WriteLine("\nGeneric class:");
SimpleDataBase<long> db = new SimpleDataBase<long>();

db.addNewData(13);
db.addNewData(02);
db.addNewData(22);

db.printAllData();