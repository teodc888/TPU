
using PracticaEF;

public class Program
{
    static void Main(string[] args)
    {
        int opcionCliente = 0;
        List<Orden> ordenList = new List<Orden>();

        do
        {
            Console.WriteLine("#######################################################");
            Console.WriteLine("Bienvenidos!!!");
            Console.WriteLine("Ingrese la Opcion 1 para cargar ordenes");
            Console.WriteLine("Ingrese la Opcion 2 si quiere saber el total de las unidades fabricadas");
            Console.WriteLine("Ingrese la Opcion 3 si quiere saber la cantidad de ordenes de produccion recibidas para las maquinas 1 y 2");
            Console.WriteLine("Ingrese la Opcion 4 si quiere saber el nombre del producto correspondiente a la orden con mayor cantidad de unidades");
            Console.WriteLine("Ingrese la Opcion 5 si quiere saber el porcentaje de ordenes en las que se fabricó mas de 20 unidades");
            Console.WriteLine("Ingrese la Opcion 6 si quiere mostrar listado de ordenes realizadas");
            Console.WriteLine("Ingrese la Opcion 0 para salir");
            Console.WriteLine("#######################################################");

            opcionCliente = ValidacionopcionCliente(opcionCliente);


            switch (opcionCliente)
            {
                case 1:
                    ordenList = CargarOrdenes(ordenList);
                    break;
                case 2:
                    if (ordenList.Count > 0)
                    {
                        int UnidadesTotales = CantidadUnidadesTotal(ordenList);
                        Console.WriteLine("La cantidad de unidades totales es de: " + UnidadesTotales);
                    }
                    else
                    {
                        Console.WriteLine("Primero debe cargar ordenes");
                    }

                    break;
                case 3:
                    if (ordenList.Count > 0)
                    {
                        int cantidadUnidades = CantidadMaquina1Y3(ordenList);
                        Console.WriteLine("La cantidad de ordenes de produccion entre la maquina 1 y 2 es de : " + cantidadUnidades);
                    }
                    else
                    {
                        Console.WriteLine("Primero debe cargar ordenes");
                    }

                    break;
                case 4:
                    if (ordenList.Count > 0)
                    {
                        string nombreProducto = NombreConMayorUnidades(ordenList);
                        Console.WriteLine("El nombre del producto correspondiente a la orden con mayor cantidad de unidades es: " + nombreProducto);

                    }
                    else
                    {
                        Console.WriteLine("Primero debe cargar ordenes");
                    }

                    break;
                case 5:
                    if (ordenList.Count > 0)
                    {
                        float porcentaje = PorcentajeUnidades(ordenList);
                        Console.WriteLine("El porcentaje de ordenes en las que se fabricó mas de 20 unidades es : " + porcentaje + "%");
                    }
                    else
                    {
                        Console.WriteLine("Primero debe cargar ordenes");
                    }
                    break;
                case 6:
                    if (ordenList.Count > 0)
                    {
                        MostrarOrdenes(ordenList);
                    }
                    else
                    {
                        Console.WriteLine("Primero debe cargar ordenes");
                    }
                    break;
                default:
                    break;
            }


        } while (opcionCliente != 0);
    }


    public static int ValidacionopcionCliente(int opcionCliente)
    {

        string respuesta;
        bool validarSoloNumeros;
        bool numeroValido;

        do
        {
            respuesta = Console.ReadLine();

            if (!String.IsNullOrEmpty(respuesta))
            {
                validarSoloNumeros = ContieneSoloNumeros(respuesta);

                if (!validarSoloNumeros)
                {
                    Console.WriteLine("Por favor ingrese solo números.");
                    numeroValido = false;
                }
                else
                {
                    opcionCliente = int.Parse(respuesta);

                    if (opcionCliente < 0 || opcionCliente > 6)
                    {
                        Console.WriteLine("El número de orden debe estar entre 0 y 6.");
                        numeroValido = false;
                    }
                    else
                    {
                        numeroValido = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Por favor ingrese una respuesta.");
                numeroValido = false;
            }

        } while (!numeroValido);


        return opcionCliente;
    }

    public static bool ContieneSoloNumeros(string texto)
    {
        return texto.All(char.IsDigit);
    }

    public static List<Orden> CargarOrdenes(List<Orden> ordenList)
    {
        int numeroOrden;
        string respuesta;
        bool validarSoloNumeros;

        do
        {
            Console.WriteLine("ingrese el numero de orden");
            Orden orden = new Orden();

            do
            {
                respuesta = Console.ReadLine();

                if (!String.IsNullOrEmpty(respuesta))
                {
                    validarSoloNumeros = ContieneSoloNumeros(respuesta);

                    if (!validarSoloNumeros)
                    {
                        Console.WriteLine("Por favor ingrese solo números.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor ingrese una respuesta.");
                    validarSoloNumeros = false;
                }

            } while (!validarSoloNumeros);

            numeroOrden = int.Parse(respuesta);
            orden.NumeroOrden = numeroOrden;

            if (numeroOrden != 0)
            {
                Console.WriteLine("ingrese el nombre del producto: ");
                orden.NombreProducto = Console.ReadLine();

                Console.WriteLine("ingrese la cantidad de unidades fabricadas: ");
                orden.UnidadesFabricadas = Int32.Parse(Console.ReadLine());

                bool banderaNumeroMaquina;
                do
                {
                    Console.WriteLine("ingrese el numero de maquina (entre el 1 y 4): ");

                    orden.NumeroMaquina = int.Parse(Console.ReadLine());

                    if (orden.NumeroMaquina <= 4 && orden.NumeroMaquina >= 1)
                    {
                        banderaNumeroMaquina = true;
                    }
                    else
                    {
                        banderaNumeroMaquina = false;
                    }


                } while (!banderaNumeroMaquina);

                ordenList.Add(orden);
            }



        } while (numeroOrden != 0);


        return ordenList;
    }

    public static void MostrarOrdenes(List<Orden> ordenList)
    {
        foreach (Orden orden in ordenList)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Numero Orden: " + orden.NumeroOrden);
            Console.WriteLine("Nombre Producto Orden: " + orden.NombreProducto);
            Console.WriteLine("Unidades Fabricadas Orden: " + orden.UnidadesFabricadas);
            Console.WriteLine("Numero Maquina Orden: " + orden.NumeroMaquina);
            Console.WriteLine("--------------------------------------------------------");
        }
    }

    public static int CantidadUnidadesTotal(List<Orden> ordenList)
    {
        int UnidadesTotales = 0;
        foreach (Orden orden in ordenList)
        {
            UnidadesTotales = UnidadesTotales + orden.UnidadesFabricadas;
        }

        return UnidadesTotales;
    }

    public static int CantidadMaquina1Y3(List<Orden> ordenList)
    {
        int cantidadUnidades = 0;

        foreach (Orden orden in ordenList)
        {
            if (orden.NumeroMaquina == 1 || orden.NumeroMaquina == 2)
            {
                cantidadUnidades++;
            }
        }

        return cantidadUnidades;
    }

    public static string NombreConMayorUnidades(List<Orden> ordenList)
    {
        string nombre = "";
        int cantidad = 0;
        bool banderaCantidad = false;
        foreach (Orden orden in ordenList)
        {
            if (banderaCantidad)
            {
                if (orden.UnidadesFabricadas > cantidad)
                {
                    nombre = orden.NombreProducto;
                    cantidad = orden.UnidadesFabricadas;
                }
            }
            else
            {
                nombre = orden.NombreProducto;
                cantidad = orden.UnidadesFabricadas;
                banderaCantidad = true;
            }
        }


        return nombre;
    }

    public static float PorcentajeUnidades(List<Orden> ordenList)
    {
        float porcentaje = 0;
        int cantidadOrdenes = 0;
        int totalOrdenes = ordenList.Count;

        foreach (Orden orden in ordenList)
        {
            if (orden.UnidadesFabricadas >= 20)
            {
                cantidadOrdenes++;
            }
        }

        porcentaje = ((float)cantidadOrdenes / totalOrdenes) * 100;


        return porcentaje;
    }

}
