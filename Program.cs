using System;

namespace laba4
{
    public class Owner
    {
        public string ID { get; } = "31052001";
        public string NAME { get; } = "Ilya";
        public string ORG { get; } = "bstu";
    }
    class DATA
    {
        public string dataName = "дата создания 14.10.2019";
    }

    class Stack:DATA
    {
        private int _currentSize;//текущий размер
        private int _stackMaxsize;//максимальный размер
        private int[] _dataArray;//данные
        public int _data;
        public Stack(int stackMaxsize)
        {
            _currentSize = 0;
            _stackMaxsize = stackMaxsize;
            _dataArray = new int[stackMaxsize];
            
        }
        public int Size()
        {
            return _currentSize;
        }
        public void Push(int item)//добавление
        {
            if (_currentSize == _stackMaxsize)
            {
                RebuildData();
            }
            _dataArray[_currentSize]= item;
            _currentSize++;

        }
        public int Peek()//чтение главного элемента 
        {
            if(Size()==0)
            {
                throw new Exception("Stack is empty");
            }
            return _dataArray[_currentSize - 1];
        }
        public int Pop()//извлечение
        {
            int item = Peek();
            _currentSize--;
            return item;
        }
        public void Clear()
        {
            _dataArray = new int[_stackMaxsize];
            _currentSize = 0;
        }
        public void RebuildData()
        {
            var newData = new int[_stackMaxsize];
            for(var i=1;i< _dataArray.Length; i++)
            {
                newData[i - 1] = _dataArray[i];
            }
            _dataArray = newData;
            _currentSize = _stackMaxsize - 1;  
        }
        
        public static Stack operator +( Stack c1, int item_2)
        {
            if (c1._currentSize == c1._stackMaxsize)
            {
                c1.RebuildData();
            }
            c1._dataArray[c1._currentSize] = item_2;
            c1._currentSize++;
            return c1;
        }
        public static Stack operator --(Stack c1)
        {
            if (c1.Size() == 0)
            {
                throw new Exception("Stack is empty");
               
            }
            c1._currentSize--;
            c1._data = c1._dataArray[c1._currentSize];
            return c1;
        }
        public static bool operator true (Stack c1)
        {
           
            
            return c1.Size() == 0;
        }
        public static bool operator false(Stack c1)
        {
            return c1.Size() != 0;
        }
        public static Stack operator >(Stack c1,Stack c2)
        {
            c2._currentSize = c1._currentSize;
            c2._stackMaxsize = c1._stackMaxsize;
            for (int i=0;i<c1.Size();i++)
            {
                c2._dataArray[i] = c1._dataArray[i];
            }
            return c2;
        }
        public static Stack operator <(Stack c1, Stack c2)
        {
            return c1;
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack stack = new Stack(3);
            Stack stack2 = new Stack(3);
            stack.Push(1);
            stack = stack + 2;
            stack = stack + 3;
            stack2 = stack > stack2;
            if (stack){ 
                Console.WriteLine("YES");
            } 
            else{
                Console.WriteLine("NO");
            }
            while (stack2.Size() > 0)
            {
                stack2--;
                Console.WriteLine(stack2._data);

            }
            Owner owner = new Owner();
            Console.WriteLine(owner.ID);
            Console.WriteLine(owner.NAME);
            Console.WriteLine(owner.ORG);
            Console.ReadLine();
        }
    }
}
