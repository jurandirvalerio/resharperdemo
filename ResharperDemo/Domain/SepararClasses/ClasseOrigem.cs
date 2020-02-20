using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SepararClasses
{
	class ClasseOrigem
	{
		public int Codigo { get; set; }
	}

	class ClasseDerivada : IClasseDerivada
	{
		public int Codigo { get; set; }
	}

	interface IClasseDerivada
	{
		int Codigo { get; set; }
	}
}
