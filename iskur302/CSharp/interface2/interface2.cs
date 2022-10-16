using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{
    internal interface Iinterface2
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServer : Iinterface2
    {
        public void Add()
        {
            Console.WriteLine("SqlServer'da ekleme işlemi yapıldı.");
        }

        public void Delete()
        {
            Console.WriteLine("SqlServer'da silme işlemi yapıldı.");
        }

        public void Update()
        {
            Console.WriteLine("SqlServer'da güncelleme işlemi yapıldı.");
        }
    }
    class OracleServer : Iinterface2
    {
        public void Add()
        {
            Console.WriteLine("OracleServer'da ekleme işlemi yapıldı.");
        }

        public void Delete()
        {
            Console.WriteLine("OracleServer'da silme işlemi yapıldı.");
        }

        public void Update()
        {
            Console.WriteLine("OracleServer'da güncelleme işlemi yapıldı.");
        }
    }
    class MySql : Iinterface2
    {
        public void Add()
        {
            Console.WriteLine("MySql'da ekleme işlemi yapıldı.");
        }

        public void Delete()
        {
            Console.WriteLine("MySql'da silme işlemi yapıldı.");
        }

        public void Update()
        {
            Console.WriteLine("MySql'da güncelleme işlemi yapıldı.");
        }
    }

    //class VeriTabaniIslemleri
    //{
    //   public void Ekle(Iinterface2 ekle)
    //    {
    //        ekle.Add();
    //    }
    //    public void Silme(Iinterface2 sil)
    //    {
    //        sil.Add();
    //    }
    //    public void Guncelle(Iinterface2 guncelle)
    //    {
    //        guncelle.Add();
    //    }
    //}
}
