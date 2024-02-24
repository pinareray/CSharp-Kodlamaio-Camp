using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
                items = new T[0];  
        }
        public void Add(T item)
        {
            T[] tempArray = items; //önceki değerleri korur.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //for ile items eski değerlerini geri alır.

            items[items.Length - 1] = item;
        }
    }
}
