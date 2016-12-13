using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student

    {
        //конструктор по умолчанию
        public Student() { }

        //создание нового студента путем копирования полей из другого
        public Student(Student copyFrom)
        {
            //копируем значения всех полей
            FIO = copyFrom.FIO;
            Nstud = copyFrom.Nstud;
            kurs = copyFrom.kurs;
            gruppa = copyFrom.gruppa;
            ozenki = copyFrom.ozenki;
        }
        public string FIO = "";
        public string Nstud = "000000";
        public int kurs = 1;
        public string gruppa = "";
        public bool budget = true;
        public byte[,] ozenki = new byte[8, 5]; //Оценки
        public override string ToString()
        {

            string strOzenki = "";
            //перебираеп семестры
            for (int i = 0; i < 2 * kurs; i++)
            {
                //выводим номер семестра в начале строки
                strOzenki += (i + 1) + " семестр: ";
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1)  //неявка
                        strOzenki += "неявка, "; //добавляем оценку к строке
                    else if (ozenki[i, j] > 1) //есть оценка
                        strOzenki += ozenki[i, j] + ", "; //добавляем оценку к строке
                };
                strOzenki += "\r\n";
            };
            return "ФИО: " + FIO + "\r\n" +
                   "№ студбилета: " + Nstud + "\r\n" +
                   "Курс: " + kurs + "\r\n" +
                   "Группа: " + gruppa + "\r\n" +
                    "Средний балл: " + SredniyBall();
        }
        //переводим на след курс
        public void PerevestiNaSledKurs()
        {
            //если курс не 4,то +1
            if (kurs < 4)
                kurs += 1;
        }
        //находим среднюю оценку
        public double SredniyBall()
        {
            double sum = 0;
            int n = 0;
            for (int i = 0; i < 2 * kurs; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] > 1)
                    {
                        sum += ozenki[i, j];
                        n++;
                    };
                };
            //если были экзамены
            if (n > 0)
                return sum / n; //средний балл = сумма / количество
            else
                return 0; //средний балл = 0
        }
        //находим стипендию за семестр
        const decimal stipSum = 1500m; // обычная стипендии
        const decimal stipPovyshSum = 1800m; // повышенная стипендии
        public decimal Stipendia(int semestr)
        {
            //если семестр не выходит за допустимые границы
            if ((semestr >= 0) && (semestr <= 2 * kurs))
            {
                if (budget) // бюджетник
                {
                    bool stip = true; //есть стипендия
                    bool stipPovysh = true; //есть повышенная стипендия
                    int n = 0;  //количество экзаменов
                    for (int i = 0; i < 5; i++)
                    {
                        if (ozenki[semestr, i] > 0) //если экзамен был
                        {
                            n++;    //увеличиваем колво экз
                            stip &= (ozenki[semestr, i] > 3); //обычная стип-оценка выше 3
                            stipPovysh &= (ozenki[semestr, i] == 5); //повыш-оценка 5
                        };
                    };
                    if (n == 0) //не было экзаменов
                        return 0; //еще нет стипендии
                    if (stipPovysh) //есть повышенная стипендия
                        return stipPovyshSum;
                    else if (stip) //есть обычная стипендия
                        return stipSum;
                    else
                        return 0;
                };
                return 0; //не бюджетник-нет стипендии
            };
            return 0; //недопуст. семестр-нет стипендии
        }
    }

    class StudentBudg : Student
    {
        public StudentBudg(Student copyFrom) : base(copyFrom) { }

        //определить стипендию за указанный семестр
        const decimal stipSum = 1500m; //сумма обычной стипендии
        const decimal stipPovyshSum = 1800m; //сумма повышенной стипендии
        public decimal Stipendia(int semestr)
        {
            //если семестр не выходит за допустимые границы
            if ((semestr >= 0) && (semestr <= kurs*2))
            {
                bool stip = true; //есть стипендия
                bool stipPovysh = true; //есть повышенная стипендия
                int n = 0;  //количество экзаменов
                for (int i = 0; i < 5; i++)
                {
                    if (ozenki[semestr, i] > 0) //если экзамен был
                    {
                        n++;    //увеличить количество экзаменов
                        stip &= (ozenki[semestr, i] > 3); //обычная стипендия - оценка выше 3
                        stipPovysh &= (ozenki[semestr, i] == 5); //повышенная - оценка 5
                    };
                };
                if (n == 0) //не было экзаменов
                    return 0; //еще нет стипендии
                if (stipPovysh) //есть повышенная стипендия
                    return stipPovyshSum;
                else if (stip) //есть обычная стипендия
                    return stipSum;
                else
                    return 0;
            };
            return 0; //недопустимый семестр - нет стипендии
        }

        //вывод информации о студенте-бюджетнике
        public override string ToString()
        {
            //формируем записи о стипендии за каждый семестр
            string stipendia = "Стипендия:\r\n";
            for (int i = 0; i < 2 * kurs; i++)
                stipendia += i + " семестр: " + Stipendia(i) + " руб.\r\n";
            //собираем результат из  
            return base.ToString() + "\r\n" //метода класса-предка (Student),
                   + "Обучение на бюджетной основе\r\n" //записи о бюджетном обучении
                   + stipendia; //и стипендии
        }
    }



    class StudentPlat : Student
    {
        public decimal stoimostObucheniya; //стоимость обучения за семестр
        public decimal oplacheno; //сколько оплатил студент в сумме

        //оплатить обучение
        public void OplatitObuchenie(decimal sum)
        {
            //долг снижается на указ сумму
            oplacheno += sum;
        }
        //задолженность за обучение (или переплата)
        public decimal Dolg()
        {
            //долг = стоимость за семестр * кол-во семестров - оплаченная сумма
            return stoimostObucheniya * kurs * 2 - oplacheno;
        }
        //скопировать
        public StudentPlat(Student copyFrom) : base(copyFrom)
        {
            //если студент copyFrom является платником
            if (copyFrom is StudentPlat)
            {
                //то скопировать стоимость обучения и сумму долга,
                //рассматривая copyFrom как платника
                stoimostObucheniya = (copyFrom as StudentPlat).stoimostObucheniya;
                oplacheno = (copyFrom as StudentPlat).oplacheno;
            };
        }

        //вывод информации о студенте-платнике
        public override string ToString()
        {
            //собираем результат из  
            return base.ToString() + "\r\n" //метода класса-предка (Student),
                   + "Обучение на платной основе\r\n" //записи о платном обучении
                   + "Стоимость обучения: " + stoimostObucheniya + " руб.\r\n"
                   + "Задолженность: " + Dolg() + " руб."; //и стипендии
        }
    }
}

    


    
    

