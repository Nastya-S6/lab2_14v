using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_14v
{
    class Program
    {
        static void Main(string[] args)
        {
            Hair hair = new Hair();
            Console.WriteLine("Тип документа: " + hair._Name());
            Console.WriteLine("Дата создания документа: " + hair.MetodDate());
            Console.ReadLine();
        }
    }
    class Documents
    {
        #region Поля и Инкапсуляция
        public string Name, Date;
        #region Инкапсуляция
        public string name
        {
            get; private set;
        }
        public string date
        {
            get; private set;
        }
        #endregion
        #endregion
        #region Перегруженные конструкторы
        public Documents() { }
        public Documents(string Name, string Date)
        {
            this.Name = Name;
            this.Date = Date;
        }
        #endregion
        #region Методы (Статичные и виртуальные)
        public static string MetodName()
        {
            return "Текстовый документ";
        }
        public virtual string MetodDate()
        {
            return "06.04.2020";
        }
        #endregion
    }
    class Hair : Documents, IObject
    {
        public string _Name()
        {
            return "Текстовый документ";
        }
    }
    public interface IObject
    {
        string _Name();
    }
}
