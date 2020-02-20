using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SepararClasses
{
	// ctrl r + ctrl + o => move
	public class ClasseOrigem
	{
		public int Codigo { get; set; }
	}

	public class ClasseDerivada : IClasseDerivada
	{
		public int Codigo { get; set; }
	}

	public interface IClasseDerivada
	{
		int Codigo { get; set; }
	}
}