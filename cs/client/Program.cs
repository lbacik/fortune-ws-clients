using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneService.FortuneSrvSoapClient f = new FortuneService.FortuneSrvSoapClient();
            Console.WriteLine(f.getFortuneStr("debian"));
        }
    }
}
