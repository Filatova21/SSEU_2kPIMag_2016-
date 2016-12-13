using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Ozenki
    {
        byte[,] ozenki = new byte[8, 5]; //Оценки

        public byte this[int semestr, int ekzamen]
        {
            get
            {
                //если номер семестра и экзамена корректный
                if ((semestr >= 1 && semestr <= 8) && (ekzamen >= 1 && ekzamen <= 5))
                {
                    //то вернуть оценку
                    return ozenki[semestr - 1, ekzamen - 1];
                };
                //иначе - считаем, что такого экзамена нет, вернуть 0
                return 0;
            }

            set
            {
                //если номер семестра и экзамена корректный
                if ((value >= 0 && value <= 5)
                     && (semestr >= 1 && semestr <= 8) && (ekzamen >= 1 && ekzamen <= 5))
                {
                    //то вернуть оценку
                    ozenki[semestr - 1, ekzamen - 1] = value;
                };
                //иначе - ничего не сохраняем
            }
        }
    }
    class Student

    {
        string fio = "";
        string nstud = "000000";
        int kurs = 1;
        string gruppa = "";
        public bool budget = true;
        Ozenki ozenki = new Ozenki(); //Оценки

        //свойство для доступа к оценкам
        public Ozenki Ozenki
        {
            get
            {
                return ozenki;
            }
        }
        //свойство студенческого
        public string Nstud
        {
            get { return nstud; }
            set { nstud = value; }
        }

        //свойство гр
        public string Gruppa
        {
            get { return gruppa; }
            set { gruppa = value; }
        }

        //свойство ФИО
        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }

        public int Kurs
        {
            get
            {
                return kurs;
            }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    kurs = value;
                };
            }
        }

        //конструктор по умолчанию
        public Student() { }
        //создание нового студента путем копирования полей из другого
        public Student(Student copyFrom)
        {
            //копируем значения всех полей
            FIO = copyFrom.FIO;
            Nstud = copyFrom.Nstud;
            kurs = copyFrom.Kurs;
            gruppa = copyFrom.gruppa;
            ozenki = copyFrom.ozenki;
        }

        public override string ToString()
        {

            string strOzenki = "";
            //перебираеп семестры
            for (int i = 0; i < KolvoSemestrov(); i++)
            {
                //выводим номер семестра в начале строки
                strOzenki += (i + 1) + " семестр: ";
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1)  //неявка
                        strOzenki += "неявка, "; //добавляем оценку к строке
                    else if (Ozenki[i, j] > 1) //есть оценка
                        strOzenki += ozenki[i, j] + ", "; //добавляем оценку к строке
                };
                
            };
            return "ФИО: " + FIO + "\r\n" +
                   "№ студбилета: " + Nstud + "\r\n" +
                   "Курс: " + Kurs + "\r\n" +
                   "Группа: " + gruppa + "\r\n" +
                   strOzenki + "\r\n" +
                   "Средний балл: " + SredniyBall();

        }
        //переводим на след курс
        public void PerevestiNaSledKurs()
        {
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
                    if (Ozenki[i, j] > 1)
                    {
                        sum += Ozenki[i, j];
                        n++;
                    };
                };
            //если были экзамены
            if (n > 0)
                return sum / n; //средний балл = сумма / количество
            else
                return 0; //средний балл = 0
        }
        //количество семестров
        protected int KolvoSemestrov()
        {
            //в каждом курсе 2 семестра
            return 2*Kurs;
        }
        

        //количество несданных экзаменов за указанный семестр
        protected int KolvoNesdach(int semestr)
        {
            int k = 0; //по умолчанию 0
            //перебираем все экзамены за семестр
            for (int i = 0; i < 5; i++)
            {
                //если неявка или неуд
                if ((ozenki[semestr, i] == 1) || (ozenki[semestr, i] == 2))
                {
                    //то считаем как несданный
                    k += 1;
                }
            }
            //возвращаем результат
            return k;
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
            if ((semestr >= 0) && (semestr <= KolvoSemestrov()))
            {
                bool stip = true; //есть стипендия
                bool stipPovysh = true; //есть повышенная стипендия
                int n = 0;  //количество экзаменов
                for (int i = 0; i < 5; i++)
                {
                    if (Ozenki[semestr, i] > 0) //если экзамен был
                    {
                        n++;    //увеличить количество экзаменов
                        stip &= (Ozenki[semestr, i] > 3); //обычная стипендия - оценка выше 3
                        stipPovysh &= (Ozenki[semestr, i] == 5); //повышенная - оценка 5
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
            for (int i = 0; i < KolvoSemestrov(); i++)
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
        public decimal Dolg
        {
            get
            {
                //долг = стоимость за семестр * кол-во семестров - оплаченная сумма
                return stoimostObucheniya * KolvoSemestrov() - oplacheno;
            }
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
                   + "Задолженность: " + Dolg + " руб."; //и стипендии
        }


    }
}

    


    
    

