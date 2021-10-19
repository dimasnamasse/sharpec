using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Collections
{
    public class Otdel
    {
        public string name_otdela;
        public int number_otdela;
        public string rukovoditel;
    }
    public class Sotrudnik
    {
        public string name;
        public string surname;
        public string patronymic;
        public int age;
        public Otdel otdel = new Otdel();
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Sotrudnik> worker = new List<Sotrudnik>(3);
            worker.Add(new Sotrudnik { name = "Иван", surname = "Смирнов", patronymic = "Васильевич", age = 45, otdel = { name_otdela = "Юг", number_otdela=11,rukovoditel="Иванов В.В" } });
            worker.Add(new Sotrudnik { name = "Василий", surname = "Иванов", patronymic = "Григорьевич", age = 33, otdel = { name_otdela = "Север", number_otdela =228, rukovoditel = "Борисов В.Н" } });
            worker.Add(new Sotrudnik { name = "Роман", surname = "Калинин", patronymic = "Петрович", age = 26, otdel = { name_otdela = "Восток", number_otdela = 232, rukovoditel = "Ермаков З.Е" } });

            worker.GroupBy(Workers => Workers.otdel.name_otdela).ToDictionary(Workers => Workers.Key, Workers => Workers.ToList());

        }
    }

}