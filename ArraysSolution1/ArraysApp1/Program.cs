internal class Program
{
    private static void Main(string[] args)
    {
         string[] ArrayOfNames = new string[5]  { "Emi", "Sheila", "Pablo", "Juan","Jose" };
        ImprimirArray(ArrayOfNames,5);
        Console.WriteLine(" "); 
        Console.WriteLine("Ingrese el nombre que quiere buscar:");  
        string name = Console.ReadLine();
        int posicion= BuscarName(ArrayOfNames, name);
        if (posicion==-1)
        {
          Console.WriteLine("El nombre: " +name+ " no se lo encontro en la lista");
        }    
    }
    public static void ImprimirArray(string[] array, int tamanio)
    {
        for (int i = 0; i < tamanio; i++)
        {
            Console.WriteLine("Array posicion: " + i + " Valor: " + array[i]);
        }
    }
     public static int BuscarName(string[] ArrayOfString, string name) 
    {
      for (int x = 0; x < ArrayOfString.Length; x++)
      {
       
        if (ArrayOfString[x]== name)
        {
           
          Console.WriteLine(name +" esta en la posicion: "+x);
          return x;
        }    
      }
      return -1;  
    }

}