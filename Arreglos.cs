using System;

public class Class1
{
	public Class1()
	{
		int[] facturas = new int[15];
		int[] placas = new int[15];
		string[] fecha = new string[15];
		string[] hora = new string[15];
		int[] tipoVehiculo = new int[15];
		int[] caseta = new int[15];
		double[] montoPorPagar = new double[15];
		string[] metodoPago = new string[15];

	}


	public void vectorInicializado() {

		//facturas
		for (int i = 0; i < facturas.length; i++)
		{
			facturas[i] = 0;
		}

		//placas
		for (int i = 0; i < placas.length; i++)
		{
			placas[i] = 0;
		}

		//fecha
		for (int i = 0; i < fecha.length; i++)
		{
			fecha[i] = "";
		}

		//hora
		for (int i = 0; i < fecha.length; i++)
		{
			hora[i] = "";
		}

		//tipoVehiculo
		for (int i = 0; i < tipoVehiculo.length; i++)
		{
			tipoVehiculoturas[i] = 0;
		}

		//caseta
		for (int i = 0; i < caseta.length; i++)
		{
			caseta[i] = 0;
		}
		
		
		//montoPorPagar
		for (int i = 0; i < montoPorPagar.length; i++)
		{
			montoPorPagar[i] = 0.0f;
		}
		metodoPago
		//montoPorPagar
		for (int i = 0; i < metodoPago.length; i++)
		{
			metodoPago[i] = "";
		}


	}//vectorInicializado
}//class
