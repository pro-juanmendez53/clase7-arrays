
void Adivina()
{
    const int Oportunidades = 4;
    int numeroCPU, numeroUsuario;
    byte Intentos, BanderaControl;
    string linea;

    Random rand = new Random();     //Generar numeros entre 1 y 20
    do
    {
        numeroCPU = Convert.ToInt32(rand.Next(1, 20));
        Console.WriteLine(numeroCPU);
    } while (!((numeroCPU >= 1) & (numeroCPU <= 20)));

    Intentos = 1;
    BanderaControl = 0;
    do
    {
        Console.WriteLine("Hola, estoy pensando en un numero, cual crees que es?");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        if (numeroUsuario == numeroCPU)
        {
            Console.WriteLine("YES! adivinaste");
            BanderaControl = 1;

        }
        else
        {
            if (numeroUsuario > numeroCPU)
            {
                Console.WriteLine("El numero que ingresaste es mayor al rango");
            }
            else
            {
                Console.WriteLine("El numero que ingresaste es menor al rango");
            }

        }
        Intentos++;
    } while (((Intentos <= Oportunidades) & (BanderaControl == 0)));
    if (BanderaControl == 0) ;
    {
        Console.WriteLine("El numero que pense era: " + numeroCPU);
    }

}



static void buscarMayor()
{
    int mayor = 0;
    int numero = 0;
    int menor = 100;
    Random rand = new Random();


    for (int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);
        Console.WriteLine(numero + "\n");
        if (numero > mayor)
        {
            mayor = numero;
        }


        if (numero < menor)
        {

            menor = numero;
        }

    }
    Console.WriteLine("el numero mayor es: " + mayor);
    Console.WriteLine("el numero menor es: " + menor);

}


static void arreglos()
{
    int[] notas = new int[15];
    Random rnd = new Random();
    Console.WriteLine("Cargando Informacoin");
    for (int i = 0; i <= notas.Length; i++)
    {
        notas[i] = rnd.Next();
    }
    Console.WriteLine("Desplegando informacion");
    int mayor = 0;
    int promedio = 0;
    int menor = 100;

    for (int i = 0; i <= notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }


}


void nombres()
{

    int numero = 0;
    String[] nombre = new string[5];
    nombre[0] = "jairo";
    nombre[1] = "Brandon";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";


    Console.WriteLine("LISTA DE LOTERIA: ");

    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine(i + ": " + nombre[i]);
    }

    Random rnd = new Random();
    int gan;
    int gan2;

    gan = rnd.Next(nombre.Length);
    Console.WriteLine("1er LUGAR: " + nombre[gan]);

    do
    {
        gan2 = rnd.Next(nombre.Length);
    } while (gan2 == gan);
    Console.WriteLine("Tu has ganado el 2do lugar: " + nombre[gan2]);








}

nombres();    //hacer rifa, despligue primer y segundo lugar


//arreglos();



buscarMayor();  //listo
//Adivina();

