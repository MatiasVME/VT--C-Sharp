using System;

public delegate void Del (int num);

public class Programa
{
	public static void Main ()
	{
		OtraClase objOtraClase = new OtraClase ();

//		Del objDel1 = new Del (OtraClase.Metodo1);
		Del objDel1 = objOtraClase.Metodo1;
		objDel1 += objOtraClase.Metodo1;

		Del objDel2 = objOtraClase.Metodo2;

		Del objDel3 = objDel1 + objDel2;
		objDel3 += OtraClase.Metodo3;

		Del objDel4 = delegate (int nnn)
			{ Console.WriteLine("nnn: " + nnn); };

		objDel3 += objDel4;

		int invocationCount = objDel3.GetInvocationList().GetLength(0);

		objDel3 (2);
		Console.WriteLine(invocationCount);
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

	public static void Metodo3 (int nn)
	{
		Console.WriteLine("nn: " + nn);
	}
}
