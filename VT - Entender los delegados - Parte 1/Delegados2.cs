
using System;

public delegate void MiDelegado (int num);

public class Programa
{
	public static void Main ()
	{
		OtraClase objOtraClase = new OtraClase ();
		MiDelegado objMiDelegado = new MiDelegado (objOtraClase.Metodo1);

		objMiDelegado += objOtraClase.Metodo2;

		objMiDelegado(4);
	}
}

public class OtraClase
{
	public void Metodo1 (int num)
	{
		Console.WriteLine("num: " + num);
	}

	public void Metodo2 (int n)
	{
		Console.WriteLine("n: " + n);
	}
}