using System;

namespace tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string datos = "";
            int ActividadPerro = 0;
            double peso = 0.0;
            int opcion = 0;
            Double tamañoperro = 0.0;
            string nombre = "";
            string perro = "";
            string raza = "";

            do
            {
                Console.WriteLine("Bienvenido al programa de buena salud canina");
                Console.WriteLine("Por Favor ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Hola {0} Ingrse el nombre del Canino, por favor", nombre) ;
                perro = Console.ReadLine();

                Console.WriteLine("{0}... Muy original", perro);

                Console.WriteLine("¿De que tamaño es {0}?", perro);
                Console.WriteLine("1- miniatura");
                Console.WriteLine("2- pequeño");
                Console.WriteLine("3-mediano");
                Console.WriteLine("4-grande");
                datos = Console.ReadLine();
                tamañoperro = Convert.ToDouble(datos);

                Console.WriteLine("¿Cual es el peso de {0}?", perro);
                datos = Console.ReadLine();
                peso = Convert.ToDouble(datos);

               

                Console.WriteLine("¿Como considera usted la Actividad de {0}?", perro);
                Console.WriteLine("1 - actividad alta");
                Console.WriteLine("2 - actividad normal");
                Console.WriteLine("3 - actividad baja");
                datos = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(datos);

                // tamaño miniatura 
                switch (tamañoperro)

                {
                    case 1:


                        if (peso <= 5 && peso >= 2)
                            Console.WriteLine("¿Que raza es {0}?", perro);
                        Console.WriteLine("Beagle-1");
                        Console.WriteLine("Carlino-2");
                        Console.WriteLine("Chihuahua-3");
                        Console.WriteLine("Bulldog-4");
                        Console.WriteLine("otros-5");
                        raza = Console.ReadLine();

                {
                    switch (ActividadPerro)
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60-115 gramos de alimento");
                            break;

                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55-100 gramos de alimento");
                            break;

                        case 3:
                            Console.WriteLine("Su perro debe comer entre 45-85 gramos de alimento");
                            break;

                               

                            }               
                }
                        break;

                      



                    // Tamaño pequeño 

                    case 2:

                if (peso <= 10 && peso >= 5)
                            Console.WriteLine("¿Que raza es {0}?", perro);
                        Console.WriteLine("Caniche-1");
                        Console.WriteLine("Lebrel-2");
                        Console.WriteLine("Crestado-3");
                        Console.WriteLine("Yorkshire-4");
                        Console.WriteLine("otros-5");
                        raza = Console.ReadLine();

                        {
                    switch (ActividadPerro)
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 115-190 gramos de alimento");
                            break;

                        case 2:
                            Console.WriteLine("Su perro debe comer entre 100-170 gramos de alimento");
                            break;

                        case 3:
                            Console.WriteLine("Su perro debe comer entre 85-145 gramos de alimento");
                            break;

                    }




                }
                        break;


                    // Tamaño Mediano

                    case 3:
                if (peso <= 15 && peso >= 10)
                            Console.WriteLine("¿Que raza es {0}?", perro);
                        Console.WriteLine("Golden-1");
                        Console.WriteLine("Pit bull-2");
                        Console.WriteLine("Husky Siberiano-3");
                        Console.WriteLine("Dalmata-4");
                        Console.WriteLine("otros-5");
                        raza = Console.ReadLine();
                        {
                    switch (ActividadPerro)
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 190-255 gramos de alimento");
                            break;

                        case 2:
                            Console.WriteLine("Su perro debe comer entre 170-225 gramos de alimento");
                            break;

                        case 3:
                            Console.WriteLine("Su perro debe comer entre 145-195 gramos de alimento");
                            break;

                    }




                }
                        break;


                    // Tamaño Grande

                    case 4:
                if (peso <= 90 && peso >= 15)
                            Console.WriteLine("¿Que raza es {0}?", perro);
                        Console.WriteLine("Doberman-1");
                        Console.WriteLine("San bernando-2");
                        Console.WriteLine("Labrador-3");
                        Console.WriteLine("Pastor Aleman-4");
                        Console.WriteLine("otros-5");
                        raza = Console.ReadLine();

                        {
                    switch (ActividadPerro)
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 255-985 gramos de alimento");
                            break;

                        case 2:
                            Console.WriteLine("Su perro debe comer entre 225-870 gramos de alimento");
                            break;

                        case 3:
                            Console.WriteLine("Su perro debe comer entre 195-750 gramos de alimento");
                            break;

                    }




                }
                        break;

                   

                }


                

                Console.WriteLine("Si desea continuar 1 de lo contrario selecione el numero 4");
                datos = Console.ReadLine();
                opcion = Convert.ToInt32(datos);

            }
            while (opcion != 4);

        }
    }
}
