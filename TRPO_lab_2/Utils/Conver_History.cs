using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TRPO_lab_2.Utils
{
    public class Conver_History
    {
        //Список истории
        List<Conver_Record> historyList;

        //Директория с файлом истории
        string dir = "conver_history.json";

        //Конструктор, чтение истории из файла
        public Conver_History()
        {
            try
            {
                //считать данные из файла, если он существует
                string jsonString = File.ReadAllText(dir);

                historyList = JsonSerializer.Deserialize<List<Conver_Record>>(jsonString);
            }
            catch
            {
                //если не существует - создать пустой список
                historyList = new List<Conver_Record>();
            }
        }

        //Деструктор, запись истории в файл
        ~Conver_History()
        {
            string jsonString = JsonSerializer.Serialize(historyList);
            File.WriteAllText(dir, jsonString);
        }

        //Получить записть по индексу
        public Conver_Record GetRecord(int index)
        {
            return historyList[index];
        }

        //Получить все записи истории
        public List<Conver_Record> GetRecords()
        {
            return historyList;
        }

        //Добавление записи
        public void AddRecord(int p1, int p2, string n1, string n2)
        {
            Conver_Record newRecord = new Conver_Record(p1, p2, n1, n2);
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
