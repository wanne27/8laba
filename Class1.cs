using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{

    //abstract Description 
    #region
    abstract class Description      //описание объектов 
    {
        public string Cost(int cost)
        {

            return $"Стоимость {name} = {cost}";
        }

        public virtual string Lifetime(int life_time)
        {
            return $"Срок службы {name} = {life_time} лет";
        }

        public string name { get; set; }

        public int mass { get; set; }


    }

    #endregion


    //Ball
    #region
    class set_of_classes : Description      // мяч
    {
        public int radius { get; set; } // радиус

        public int pressure { get; set; } //давление  

        public override string ToString()
        {
            Console.WriteLine("Данные об объекте : ");

            Console.WriteLine($"Название : {name}");

            Console.WriteLine($"Радиус : {radius}");

            Console.WriteLine($"Масса : {mass}");

            Console.WriteLine($"Давление : {pressure}");


            return $"{name} {radius} {pressure} {mass}";
        }
    }
    #endregion


    // Bench, переопределение методов Object

    #region
    class Bench : Description// скамейка
    {

        public int length { get; set; }      //длина

        public int width { get; set; }       //ширина

        public override string ToString()
        {

            Console.WriteLine("Данные об объекте : ");

            Console.WriteLine($"Название : {name}");

            Console.WriteLine($"Длина : {length}");

            Console.WriteLine($"Ширина : {width}");

            Console.WriteLine($"Масса : {mass}");


            return $"{name} {length} {width} {mass}";
        }
        public override bool Equals(object obj)
        {

            if (obj == null)
                return false;
            Bench p = obj as Bench;
            if (p as Bench == null)
                return false;

            return p.length == this.length && p.width == this.width;

        }


        public override int GetHashCode()
        {

            int uCode = 0;
            if (length < 20 && length > 0)
                uCode = 1;
            if (length >= 20)
                uCode = 2;

            ; return length.GetHashCode() + uCode;

        }


    }
    #endregion


    //Mate
    #region
    class Mate : Description      //мат
    {
        public int length { get; set; }  //длина

        public int width { get; set; }   //ширина

        public int area { get; set; }    //площадь

        public override string ToString()
        {

            Console.WriteLine("Данные об объекте : ");

            Console.WriteLine($"Название : {name}");

            Console.WriteLine($"Длина : {length}");

            Console.WriteLine($"Масса : {mass}");

            Console.WriteLine($"Ширина : {width}");

            Console.WriteLine($"Площадь : {area}");



            return $"{name} {length} {width} {mass} {area}";
        }
    }
    #endregion

    //Skids
    #region
    class Skids : Description         // брусья
    {
        public int number { get; set; }

        public string color { get; set; }

        public override string ToString()
        {
            Console.WriteLine("Данные об объекте : ");

            Console.WriteLine($"Название : {name}");

            Console.WriteLine($"Цвет : {color}");

            Console.WriteLine($"Масса : {mass}");

            Console.WriteLine($"Количество : {number}");


            return $"{name} {number} {color} {mass}";
        }
    }
    #endregion

    // cube
    #region
    sealed class cube
    {
        public void Print()
        {
            Console.WriteLine("Это экземпляр бессплодного класса ! ");

        }

    }
    #endregion

    //Printer
    #region
    class Printer : Description
    {

        public void IAmPrinting(Description someobj)
        {
            Console.WriteLine(someobj.GetType());

        }
    }
    #endregion

    // Tennis
    #region
    class Tennis : Description      // теннис
    {
        public int number { get; set; }         // количесто

        public int radius { get; set; }         // радиус

        public override string ToString()
        {

            Console.WriteLine("Данные об объекте : ");

            Console.WriteLine($"Название : {name}");

            Console.WriteLine($"Количество : {number}");

            Console.WriteLine($"Радиус : {radius}");

            Console.WriteLine($"Масса : {mass}");


            return $"{name} {number} {radius} {mass}";
        }
    }

    #endregion

    //abstract class1(SUM)
    #region
    abstract class Class1
    {
        public abstract int SUM(int a, int b);
    }
    #endregion

    //Class2 SUM и SUM
    #region
    //class Class2 : Class1, Interface1
    //{
    //    //public int a { get; set; }
    //    //public int b { get; set; }
    //    int Interface1.SUM(int a, int b)
    //    {
    //        int sum = a + b;
    //        return sum;
    //    }
    //    public override int SUM(int a, int b)
    //    {

    //        int difference = a - b;
    //        return difference;
    //    }

    //}
    #endregion

}
