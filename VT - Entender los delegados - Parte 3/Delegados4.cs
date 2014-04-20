using System;
 
// Creamos un tipo delegado
public delegate int Del (int n);
 
public class Delegados4
{
    public static void Main ()
    {
        OtraClase objOtraClase = new OtraClase();

        Del objDel = objOtraClase.Metodo1;
        objDel += objOtraClase.Metodo2;

        TratarDelegados.InfoDelegado(objDel);
    }
}

public class OtraClase
{
    public int Metodo1 (int n)
    {
        return n + 1;
    }

    public int Metodo2 (int nn)
    {
        return nn + 2;
    }    
}

public class TratarDelegados
{
    public static void InfoDelegado (Delegate objDel)
    {
        Console.WriteLine("-- Información del objeto delegado --");

        if (objDel == null) {
            Console.WriteLine("\tEl objeto delegado no referencia ningún método");
            return;
        }

        foreach (Delegate d in objDel.GetInvocationList()) {
            Console.WriteLine("\tMétodo: {0}", d.Method);
            Console.WriteLine("\tClase: {0}", d.Target);
        }
    }
}
