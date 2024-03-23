using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302223119
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates = new List<DateTime>();

        public SimpleDataBase()
        {
            storedData = new List<T>();
        }
        public void addNewData(T t)
        {
            storedData.Add(t);
            inputDates.Add(DateTime.Now);
        }
        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpanpada waktu UTC: {inputDates[i]}");
            }
        }
    }
}
