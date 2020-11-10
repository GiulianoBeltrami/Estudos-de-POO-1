using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente conta = new ContaCorrente(123,3214123);

			Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

			Console.ReadLine();
		}
	}
}
