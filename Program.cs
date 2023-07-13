using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laprak4
{
    class Mahasiswa
    {
        //field 
        private string _nama;
        private string _nim;
        private float _ipk;

        //properti 
        public string Nama
        {
            get
            {
                return _nama;

            }
            set
            {
               _nama = value; 
            }
            
        }
        public string Nim
        {
            get
            {
                return _nim;
            }
            set
            {
                _nim = value;
            }
            
        }
        public float IPK
        {
            get
            {
                return _ipk;
            }
            set
            {
                _ipk = value;
            }
        }
        public void InfoMahasiswa()
        {
            Console.WriteLine("================Mahasiswa Hadir==============");
            Console.WriteLine("Dengan nama  : {0}", Nama);
            Console.WriteLine("Dengan nim   : {0}", Nim);
            Console.WriteLine("Memiliki ipk : {0}", IPK);
            if (IPK < 3.00)
            {
                Console.WriteLine("anda tidak lulus");
            }
            else
            {
                Console.WriteLine("anda lulus");
            }
            Console.ReadLine();
        }
    }
    
    class Program 
    {
        static void Main(string[] args)
        {
            Mahasiswa mahasiswa1 = new Mahasiswa();
            mahasiswa1.Nama = "Dwiky Arista Vitraihan";
            mahasiswa1.Nim = "22.11.4815";
            mahasiswa1.IPK = 4f;
            mahasiswa1.InfoMahasiswa();
            Console.ReadLine();

        }
    }
}
