using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	class Pessoa
	{
		public int Nome { get; set; }
		public DateTime DataAniversario { get; set; }
		// Extrair classe
		public string Endereco { get; set; }
		public string Cidade { get; set; }
	}
}
