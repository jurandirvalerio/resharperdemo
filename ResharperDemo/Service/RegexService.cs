using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service
{
	class RegexService
	{
		void Teste()
		{
			// Ponteiro na expressão - Validate Regular Expression
			Regex.Match("10/05/1988", @"\d{2}\/\d{2}/\d{4}");
		}
	}
}
