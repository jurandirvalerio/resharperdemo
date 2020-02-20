using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	public class RefactorService
	{
		public int RandomCalc()
		{
			var x = 1;
			// ctrl + shift + r => x * x
			var y = x + x * x;

			return y;
		}
	}
}