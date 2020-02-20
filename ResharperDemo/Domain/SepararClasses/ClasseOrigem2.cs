namespace Domain.SepararClasses
{
	public class ClasseOrigem2
	{
		public int Codigo { get; set; }
	}

	public class ClasseDerivada2 : IClasseDerivada2
	{
		public int Codigo { get; set; }
	}

	public interface IClasseDerivada2
	{
		int Codigo { get; set; }
	}
}