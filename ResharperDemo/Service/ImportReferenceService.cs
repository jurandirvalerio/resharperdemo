
using System;

namespace Service
{
	public class ImportReferenceService
	{
		private List<int> intSet;
		private Hash hash;
		private WrongNameConventionRepository _wrongNameConventionRepository;

		public ImportReferenceService(string unused)
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