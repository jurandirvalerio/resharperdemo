
using System;

namespace Service
{
	public class ImportarReferenciaService
	{
		private List<int> intSet;
		private Hash hash;
		private NomeForaDaConvencaoRepository _nomeForaDaConvencaoRepository;

		public ImportarReferenciaService(string parametroSemUso)
		{
			
		}

		public void Test()
		{
			var boolean = true;

			var first = 1;
			var second = 2;

			int result = first + second;
			
			if (boolean)
			{
				result = result + 1;
			}

		}
	}
}