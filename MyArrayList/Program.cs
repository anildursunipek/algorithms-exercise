using System.Collections;

namespace Homework
{
    class Test
    {
        public static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            Random rnd = new Random();
            Console.WriteLine("-----MyArrayList Initialized-----");
            for(int i = 0; i < 10; i++)
            {
                list.MyAdd(rnd.Next(100));
            }
            list.WriteList();
            // MyRemoveAt
            Console.WriteLine("-----MyRemoveAt(4)-----");
            list.MyRemoveAt(4);
            list.WriteList();
            // MyInsert
            Console.WriteLine("-----MyInsert(3000, 2)-----");
            list.MyInsert(3000, 2);
            list.WriteList();
            // MyCount
            Console.WriteLine("-----MyCount-----");
            Console.WriteLine("Count: " + list.MyCount);
            // MyCapacity
            Console.WriteLine("-----MyCapacity-----");
            Console.WriteLine("Capacity: " + list.MyCapacity);
            // MySort
            Console.WriteLine("-----MySort-----");
            list.MySort();
            list.WriteList();
            // MyReverse Method
            Console.WriteLine("-----MyReverse-----");
            list.MyReverse();
            list.WriteList();
            // MyClear
            Console.WriteLine("-----MyClear-----");
            list.MyClear();
            list.WriteList();
        }
    }
        
    class MyArrayList
    {
        // Fields
        private int _count;
        private int _capacity;
        Object[] _MyArray;

        public MyArrayList(){
            int _capacity = 0;
            int _count = 0;
            Object[] _MyArray = new Object[_capacity];
        }
        public int MyCapacity
        {
            get { return _capacity; }
        }

        public int MyCount
        {
            get { return _count; }
        }
        public void MyAdd(Object value)
        {
            _count++;
            if (CheckCapacity())
            {
                _capacity = UpdateCapacity();
                _MyArray = UpdateMyArray();
            }
            _MyArray[_count - 1] = value;
        }
        public void MyRemoveAt(int index)
        {
            _count--;
            for(int i=index; i < _count-1; i++)
            {
                _MyArray[i] = _MyArray[i + 1];
            }
        }
        public void MyInsert(Object value, int index)
        {
            _count++;
            for(int i=_count; i > index; i--)
            {
                _MyArray[i] = _MyArray[i - 1];
            }
            _MyArray[index] = value;
        }
        public void MySort()
        {
            // Bubble Sort Algorithm
            for(int i=0; i < _count - 1; i++)
            {
                for(int j=0; j < _count - 1 - i; j++)
                {
                    if ((int)_MyArray[j] > (int)_MyArray[j + 1])
                    {
                        // Swap
                        Object temp = _MyArray[j + 1];
                        _MyArray[j + 1] = _MyArray[j];
                        _MyArray[j] = temp;
                    }
                }
            }
        }
        public void MyReverse()
        {
            Object[] temp = new object[_capacity];
            for(int i=0; i < _count; i++)
            {
                temp[i] = _MyArray[_count - 1 - i];
            }
            _MyArray = temp;
        }
        public void MyClear()
        {
            _MyArray = new Object[_capacity];
            _count = 0;
        }
        private bool CheckCapacity()
        {
            if(_count > _capacity)
            {
                return true;
            }
            return false;
        }
        private int UpdateCapacity() {
            if(_capacity * 2 == 0)
            {
                return 4;
            }
            return _capacity * 2;
        }
        private Object[] UpdateMyArray()
        {
            Object[] array2 = _MyArray;
            _MyArray = new Object[_capacity];

            for(int i=0; i < _count - 1; i++)
            {
                _MyArray[i] = array2[i];
            }
            return _MyArray;
        }
        public void WriteList()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine("Index " + i + " -> " + _MyArray[i]);
            }
            Console.WriteLine("Capacity: " + _capacity + " Count: " + _count);
        }
    }
}