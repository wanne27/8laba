using System;
using System.Collections.Generic;
using System.Text;

namespace laba4
{
    class CollectionType <T> : IActions<T> //where T : class
    {
     
        public T[] items;//данные
        const int n = 10;
        private int count;
        public CollectionType()
        {
            items = new T[n];
        }
        public CollectionType(int length)
        {
            items = new T[length];
        }
        
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        // размер стека
        public int Count
        {
            get { return count; }
        }
        public void Push(T item)//добавление
        {
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count++] = item;
        }
        // извлечение элемента
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку
            return item;
        }
        public T Peek()
        {
            return items[count - 1];
        }

        public void show(T item)
        {
            Console.WriteLine(item);
        }
    }
}
