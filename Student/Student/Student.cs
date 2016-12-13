using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string FIO = "";          
        public string Nstud = "000000";  
        public int kurs = 1;             
        public string gruppa = "";       
        public bool budget = true;       
        public byte[,] ozenki = new byte[8, 5]; //Оценки

        //содержимое полей в виде текста
        public string ToString()
        {
            return "ФИО: " + FIO + "\r\n" +
                      "№ студбилета: " + Nstud + "\r\n" +
                      "Курс: " + kurs + "\r\n" +
                      "Группа: " + gruppa + "\r\n" +
                      (budget ? "На бюджетной основе" : "На коммерческой основе") + "\r\n";
        }
    }
    
}
