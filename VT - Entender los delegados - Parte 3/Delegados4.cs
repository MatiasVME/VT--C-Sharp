using System;
 
// Creamos un tipo delegado
public delegate int Del (int n);
 
public class Delegados4
{
    public static void Main ()
    {
        Del objDel = Metodo1;
        objDel += Metodo2;

        TratarDelegados.InfoDelegado(objDel);
    }
 
    public static int Metodo1 (int n)
    {
        return n + 1;
    }
 
    public static int Metodo2 (int nn)
    {
        return nn + 2;
    }
}

public class TratarDelegados
{
    public static void InfoDelegado (Delegate objDel)
    {
        Console.WriteLine("Informacion del objeto delegado");
        
        if (objDel == null) {
            Console.WriteLine("\tEl objeto delegado no referencia a ningun metodo");
            return;
        }
        
        foreach (Delegate d in objDel.GetInvocationList ()) {
            Console.WriteLine("\tNombre del método: {0}", d.Method);
            Console.WriteLine("\tNombre de su clase: {0}", d.Target);
        }
    }
}
