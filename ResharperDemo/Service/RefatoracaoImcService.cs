using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	public class RefatoracaoImcService
	{
		public float CalcularImc(float peso, float altura)
		{
			// ctrl + shift + r 
			// inline method
			float quadradoAltura = altura * altura;
			return peso / quadradoAltura;
		}
	}
}