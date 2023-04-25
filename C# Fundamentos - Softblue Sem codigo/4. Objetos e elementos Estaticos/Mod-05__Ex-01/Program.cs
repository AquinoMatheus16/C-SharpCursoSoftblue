using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			//Cria um triângulo, dá valor aos fields e calcula a área
			Triangulo tr = new Triangulo();
			tr.@base = 2.5;
			tr.altura = 4;
			double area = tr.CalcularArea();
			Console.WriteLine("Área triângulo: " + area);
		
			//Cria um quadrado, dá valor aos fields e calcula a área
			Quadrado q = new Quadrado();
			q.lado = 3.2;
			area = q.CalcularArea();
			Console.WriteLine("Área quadrado: " + area);
		
			//Cria uma circunferência, dá valor aos fields e calcula a área
			Circunferencia c = new Circunferencia();
			c.raio = 5;
			area = c.CalcularArea();
			Console.WriteLine("Área circunferência: " + area);
		
			//Cria um trapézio, dá valor aos fields e calcula a área
			Trapezio tp = new Trapezio();
			tp.baseMaior = 7.1;
			tp.baseMenor = 3.6;
			tp.altura = 2;
			area = tp.CalcularArea();
			Console.WriteLine("Área trapézio: " + area);
		}
	}

	class Triangulo
	{
		// Base (a '@' deve ser usada porque 'base' é uma palavra reservada do C#)
		public double @base;

		// Altura
		public double altura;

		public double CalcularArea()
		{
			double area = @base * altura / 2;
			return area;
		}
	}

	class Quadrado
	{
		// Lado do quadrado
		public double lado;

		public double CalcularArea()
		{
			// Multiplica o lado por ele mesmo
			double area = lado * lado;
			return area;
		}
	}

	class Circunferencia
	{
		// Raio da circunferência
		public double raio;

		public double CalcularArea()
		{
			// Math.PI é a constante que representa o PI (3,14159265...)
			double area = Math.PI * raio * raio;
			return area;
		}
	}

	class Trapezio
	{
		// Altura
		public double altura;

		// Base maior
		public double baseMaior;

		// Base menor
		public double baseMenor;

		public double CalcularArea()
		{
			double area = ((baseMaior + baseMenor) / 2) * altura;
			return area;
		}
	}

	
}
