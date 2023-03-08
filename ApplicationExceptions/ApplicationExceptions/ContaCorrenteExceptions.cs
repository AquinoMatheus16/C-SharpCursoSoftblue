using System;

namespace ApplicationExceptions
{
	public class ContaCorrenteException : Exception
	{
		public ContaCorrenteException() { }
		public ContaCorrenteException(string message) : base(message) { }
		public ContaCorrenteException(string message, Exception inner) : base(message, inner) { }

	}
}
