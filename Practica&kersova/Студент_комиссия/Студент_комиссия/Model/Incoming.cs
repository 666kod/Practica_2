using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Студент_комиссия.Model
{
    class Incoming
    {
        private string surname; //фамилия
        private string name; //имя
        private string patronymic;//отчество
        private string pol; //пол
        private DateTime datadn;//дата рождения
        private string[] name_predmet;//имя предметов
        private int[] bal_predmet;// их балл
        public int Age()//ВОЗРАСТ
        {

            DateTime now = DateTime.Today;
            int age = now.Year - datadn.Year;
            now = now.AddYears(-age);
            if (datadn > now) age--;
            return age;
        }
            public Incoming(string xsurname, string xname,string xpatronymic, string xpol, DateTime xdatadn,string[] xname_predmet,int[] xbal_predmet)
        {
             surname= xsurname; //фамилия
             name=xname; //имя
             patronymic = xpatronymic;//отчество
             pol=xpol; //пол
             datadn=xdatadn;//дата рождения
             name_predmet = xname_predmet;
             bal_predmet = xbal_predmet;
        }
        public Incoming(Incoming A)
        {
            surname = A.surname; //фамилия
            name = A.name; //имя
            patronymic = A.patronymic;//отчество
            pol = A.pol; //пол
            datadn = A.datadn;//дата рождения
            name_predmet = A.name_predmet;//название предметов
            bal_predmet = A.bal_predmet;//их балл

        }
        public string show()
        {
            string txt = $"\nФамилия: {surname}\n";
            txt += $"Имя: {name}\n";
            txt += $"Пол: {pol}\n";
            txt += $"Дата рождения: {datadn.Day}-{datadn.Month}-{datadn.Year}\n";
            txt += $"Возраст: {Age()}\n";
            txt += $"Средний балл {srball()}\n";
            for (int i=0;i<name_predmet.Length;i++)
            {
                txt += $" {name_predmet[i]}: {bal_predmet[i]}\n";
            }
            txt += $"\n";
            return txt;
        }
        public int srball()
        {
            int b = 0;
            for (int i = 0; i < bal_predmet.Length; i++) b += bal_predmet[i];
            return b;  
        }
    }
    
}

