using System;

namespace AllListCostum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyList<string> mylist = new MyList<string>();


            mylist.Add("Uzeyir");
            mylist.Add("Cavansir");
            mylist.Add("Cavid");
            //mylist.Clear("Cemsid");
            //mylist.Clear("Uzeyir");
            //mylist.Find("Uzeyir");
            //mylist.AddRange(mylist);

            mylist.GetAll();



        }
    }





    public class MyList<T>
    {
        private T[] arr;

        public MyList()
        {
            arr = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
        }

        public void Clear(T data)
        {
            Console.Clear();
        }


        public void Find(T data)
        {
            var result = data;
            foreach (var item in arr)
            {
                if (true)
                {

                    Console.WriteLine(item);
                    break;
                }

            }

        }

        //public void AddRange( MyList<string> myList)
        //{
        //    string[] name = { "Qafur", "Emil" };


        //    myList.AddRange(myList);
        //}

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}