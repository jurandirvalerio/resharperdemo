using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Pessoa
	{
		public int Nome { get; set; }
		public DateTime DataAniversario { get; set; }
		// Extrair classe
		// ctrl + r + ctrl + o
		public string Cep { get; set; }
		public string Cidade { get; set; }

		public Pessoa(int nome, DateTime dataAniversario, string cep, string cidade)
		{
			Nome = nome;
			DataAniversario = dataAniversario;
			Cep = cep;
			Cidade = cidade;
		}
	}
}