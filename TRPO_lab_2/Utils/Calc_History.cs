using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TRPO_lab_2.Utils
{
    class Calc_History
    {

        //Список истории
        List<Calc_Record> historyList;

        //Директория с файлом истории
        string dir = "calc_history.json";

        //Конструктор, чтение истории из файла
        public Calc_History()
        {
            try
            {
                //считать данные из файла, если он существует
                string jsonString = File.ReadAllText(dir);

                historyList = JsonSerializer.Deserialize<List<Calc_Record>>(jsonString);
            }
            catch
            {
                //если не существует - создать пустой список
                historyList = new List<Calc_Record>();
            }
        }

        //Деструктор, запись истории в файл
        ~Calc_History()
        {
            string jsonString = JsonSerializer.Serialize(historyList);
            File.WriteAllText(dir, jsonString);
        }

        //Получить записть по индексу
        public Calc_Record GetRecord(int index)
        {
            return historyList[index];
        }

        //Получить все записи истории
        public List<Calc_Record> GetRecords()
        {
            return historyList;
        }

        //Добавление записи
        public void AddRecord(Calc_Record newRecord)
        {
            historyList.Add(newRecord);
        }

        //Очитска Истории
        public void Clear()
        {
            historyList.Clear();

            File.Delete(dir);
        }

        //Получение количества элементов истории
        public int Count()
        {
            return historyList.Count;
        }
    }
}
