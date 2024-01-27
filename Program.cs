internal class Program
{
    private static void Main(string[] args)
    {
        /* 
        Realizar un programa que reciba una contraseña y la verifique
        con una variable guarda que tenga la contraseña.

        Al tercer intento mandará un mensaje diciendo , fallor al entrar
        Si lograr adivinar la contraseña, mandara un mensaje de éxito"
        */
    
        string password = "Admin123$";
        int veces = 3;

        Console.WriteLine($"Escribe la contraseña, tienes {veces} intentos");
        string validarPass = "";
        validarPass = Console.ReadLine();
        veces--;

        while (veces > 0)
        {
           if (validarPass == password) 
           {
                Console.WriteLine("Contraseña Encontrada");
                break; 
           }
           else 
           {
                Console.WriteLine("Contraseña invalida");

                Console.WriteLine($"Escribe la contraseña, tienes {veces} intentos");
                validarPass = Console.ReadLine();
            }

            veces--;
        }

        if (veces == 0 || validarPass != password) 
        {
            Console.WriteLine("NO LOGRASTE ENTRAR");
        }
        

    }

    public static int CalcularEdad(DateTime fechaDeNacimiento) 
    {
        int edad = DateTime.Today.Year - fechaDeNacimiento.Year;
        return edad;
    }
}




enum TiposAlumnos
{
    Remotos = 1,
    Presenciales = 2
    
}

/*

        Console.WriteLine("Hello, World!");

        int edad = CalcularEdad(new DateTime(1979,7,22));
        Console.WriteLine($"La edad es: {edad}");

        

        //SENTENCIAS DE CONDICIONES
        if (true)
        {
            if (true)
            {
                
            }
            else
            {
                
            }
        }
        else 
        {

        }

        TiposAlumnos tipo = TiposAlumnos.Presenciales;

        switch (tipo)
        {
            case TiposAlumnos.Remotos:

                break;

            case TiposAlumnos.Presenciales:

                break;
        }

        //SENTENCIAS DE CICLOS
        do
        {
            
        } while (true);

        while (true)
        {
            
        }

        for (var i = 0; i < length; i++)
        {
            
        }

        //Arregos, Vectores[1];  Matrices[2,3]


        //TIPOS DE DATOS
        int edad = 5;
        bool activo = false;

        string nombre = "Ricardo";
        char letra = 'a';

        double estatura = 1.89;
        decimal cantidadXPagar = 200.59M;

        byte valor = 2;
        DateTime fecha = new DateTime(2010,7,23);
*/