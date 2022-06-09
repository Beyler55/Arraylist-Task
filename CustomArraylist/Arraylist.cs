using System;

namespace CustomArraylist
{
    public class Arraylist
    {
        private object[] _arr;
        public int Capacity { get; set; }
        public int Count { get; set; }
        public Arraylist(int capacity)
        {
            Capacity = capacity;
            _arr = new object[capacity];
        }
        int index = 0;
        public void Add(object value)
        {
            if (Count < Capacity)
            {
                Array.Resize(ref _arr, Capacity);
                _arr[index] = value;
                index++;
            }
            else if (Count > Capacity || Count == Capacity)
            {
                Capacity = Capacity * 2;
                Array.Resize(ref _arr, Capacity);
                _arr[index] = value;
                index++;
            }
            Count++;
        }

        public void Remove(object value)
        {
            int valindex = Array.IndexOf(_arr, value);
            int index = 0;
            while (index != valindex)
            {
                index++;
            }
            while (index < _arr.Length - 1)
            {
                _arr[index] = _arr[index + 1];
                index++;
            }
            valindex--;
        }
        public void RemoveAt(int removedindex)
        {
            int index = 0;
            while (index != removedindex)
            {
                index++;
            }
            while (index < _arr.Length - 1)
            {
                _arr[index] = _arr[index + 1];
                index++;
            }
            removedindex--;
        }
        public  void TrimToSize()
        {
            
        }
        public void AddRange(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length-1] = array[i];
            }

        }
        public void GetAll()  //print all elements
        {
            for (int i = 0; i <_arr.Length; i++)
            {
                if (_arr[i]!=null)
                {
                    Console.WriteLine(_arr[i]);
                }
            }
        }
    }
}
