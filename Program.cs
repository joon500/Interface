using System;


namespace My4
{
    public interface IMyList<T>
    {
        void Add2(T a);
    }
    class Program
    {

        public class MyList<T> : IMyList<T>
        {
            public int ff;
            public void Add2(T a)
            {
                //add same
            }
        }
        static void Main(string[] args)
        {
            IMyList<int> list1 = new MyList<int>(); // 1 вариант

            var list2 = new MyList<int>(); // 2 вариант

            MyList<int> list3 = new MyList<int>(); // 3 вариант




        }
    }
}
