using System;

public class Class1
{
	static void Main(string[] args)
	{

	}

	int vueltos[] = { 700, 3700, 500, 2700 };

		static void Ingresar()
		{
		Arreglos objArreglo = new Arreglos();
		for (int i = 0; i < facturas.length; i++)
		{
			Console.WriteLine("Digite el número de la factura ");
			int numFactura = int.Parse(Console.ReadLine());		
	facturas[i] = numFactura;
		}

		for (int i = 0; i < placas.length; i++)
		{
			Console.WriteLine("Digite el número de la placa ");
			int placas = int.Parse(Console.ReadLine());
			placas[i] = placas;
		}
		
		
		for (int i = 0; i < fecha.length; i++)
		{
			Console.WriteLine("Digite fecha " );
			string fecha = Console.ReadLine();
			fecha[i] = fecha;
		}


		for (int i = 0; i < hora.length; i++)
		{
			Console.WriteLine("Digite hora " + i);
			string hora = Console.ReadLine();
			hora[i] = hora;
		}


		for (int i = 0; i < tipoVehiculo.length; i++)
		{
			Console.WriteLine("Digite numero de tipo de vehiculo:(1= Moto ,2= Vehículo Liviano, 3 =Camión o Pesado 4=Autobús) " + i);
			int tipoVehiculo = int.Parse(Console.ReadLine());
			tipoVehiculo[i] = tipoVehiculo;
		}

		for (int i = 0; i < caseta.length; i++)
		{
			Console.WriteLine("Digite numero de caseta (1, 2, 3)");
			int caseta = int.Parse(Console.ReadLine());
			caseta[i] = caseta;
		}

		for (int i = 0; i < montoPorPagar.length; i++)
		{
			Console.WriteLine("Digite monto por pagar (Moto = 500, Liviano = 700, Camión o Pesado = 2500, Autobús = 3700");
			double montoPago = double.Parse(Console.ReadLine());
			montoPago[i] = montoPago;
		}



		for (int i = 0; i < metodoPago.length; i++)
		{
			Console.WriteLine("Digite metodo de pago (tarjeta, efectivo) ");
			string metodoPago = Console.ReadLine();
			metodoPago[i] = metodoPago;
		}


		

	}

		static void Consulta()
		{ Console.WriteLine("Seleccione número de consulta (entre 1 y 15)");
			int numeroConsulta = int.Parse(Console.ReadLine());

		double resultado;
		double vuelto;
		Console.WriteLine("Digite el monto pagado");
		vuelto = double.Parse(Console.ReadLine());
		resultado = vuelto - montoPago[numeroConsulta];

		string op = "                REGISTRO FLUJO VEHICULAR             ";
		op += "  Número factura: " + factura[numeroConsulta] + "              ";
		op += "  Número placa: " + placas[numeroConsulta] + "                 ";
		op += "  Fecha: " + fecha[numeroConsulta] + "                         ";
		op += "	 Hora: " + hora[numeroConsulta] + "                           ";
		op += "	 Tipo de vehículo: " + tipoVehiculo[numeroConsulta] + "                           ";
		op += "	 Número caseta: " + caseta[numeroConsulta] + "                           ";
		op += "	 Monto por pagar: " + montoPago[numeroConsulta] + "                           ";
		op += "	 Paga con: " + metodoPago[numeroConsulta] + "                           ";
		op += "	 Vuelto: " + resultado + "  colones                                  ";



		}

	static void Modificar()
	{
	}

		static void Reporte()
		{

		}
	}






}
}
