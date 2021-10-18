using Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static void Main(string[] args)
        {

            using(FileStream fs = new FileStream("c:/test/test.exe", FileMode.Open))
            {

            }



            using (ManoKlase manoKlase = new ManoKlase())
            {
                manoKlase.ToString();
            }

        }


        public class ManoKlase : IDisposable
        {
            string[] labaiDidelisMasyvas = new string[1000];

            public void Dispose()
            {
                labaiDidelisMasyvas = null;
            }
        }
    }
}
