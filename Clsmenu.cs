using System;

public class Class1
{
	public Class1()
	{
		public static void menu()
		{

			Arreglos objArreglo = new Arreglos();
			ClsTransacciones transac = new ClsTransacciones();

			byte opcion = 0;

			do
			{
				Console.WriteLine("1- Inicializar vectores");
				Console.WriteLine("2- Ingresar paso vehicular");
				Console.WriteLine("3- Consulta de vehívulos por número de placa");
				Console.WriteLine("4- Modificar datos de los vehículos por número de placa");
				Console.WriteLine("5- Reporte de todos los datos de los vectores");
				Console.WriteLine("6- Salir")
				opcion = byte.Parse(Console.ReadLine());

}
 switch (opcion)
			{
				case 1:
					Console.WriteLine("1- Inicializar vectores"); objArreglo.vectorInicializado();
					break;
				case 2:
					Console.WriteLine("2- Ingresar paso vehicular");  transac.Ingresar();
					break;
				case 3:
					Console.WriteLine("3- Consulta de vehívulos por número de placa"); transac.Consulta();
					break;
				case 4: 
					Console.WriteLine("4- Modificar datos de los vehículos por número de placa") ModificarDatos();
				break;
					case 5:
						Console.WriteLine("5- Reporte de todos los datos de los vectores") transac.Reporte();
				break; 
				case 6:
					Console.WriteLine("6- Salir");
					break;
				default:
					break;
			}

		} while (opcion != 6) ;
	}



}
