using Domain.Usuarios;
using System;

namespace Domain
{
	public class Pedido
	{
		public Guid Guid { get; set; }
		public DateTime Data { get; set; }

		public Pessoa Pessoa { get; set; }

		//ctorp
	}
}