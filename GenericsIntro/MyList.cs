using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>//MyListte T ile çalışacağım anlamına geliyor
    {
        T[] items;//classın bütün elemanlarının ulaşabilceği bir sizi tanımlıyoruz //array newlenmeli

        public MyList()//constructor
        {
            items = new T[0];//newledğimiz anda çalışan bloğa constructor deniliyor
        }
        public void Add(T item)//ben sana T olarak hangi tipi veirisem o tipte eleman ekler 
            //biz add'in içinde yukarıdaki items'ı eklemek istiyoruz ancak onu ekleyebilmemiz için newlememiz gerekiyor çünkü array referans tip başaladığında 0 elemanlı olarak newlemek istiyoruz bunu da constroctor yardımıyla yapıyoruz 
        {
            T[] tempArray = items;//itemsın referansını geçici dizinin referansına atıyoruz çünkü bunu yazmazsak aşağıda newlediğimiz için önceki yazdığımız değerler gözükmez örneğin engin yazılıysa ilk başta aşağıda newlendiğinde engin gider.
            items = new T[items.Length + 1];//yukarıda dizimizi 0 elemanlı olarak newledik burada 1 arttırıyoruz
            for(int i= 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//bu kısımda geçici değerleri koyduğuuz tempArraydan değerlerimizi geri alıyoruz
            }
            items[items.Length-1] = item;
        
        }
    }
}
