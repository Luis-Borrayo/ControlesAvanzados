using System;

public class Venta
{
	public int Anio {  get; set; }
	public int Mes {  get; set; }
	public string Departamento { get; set; }
	public int NumVentas { get; set; }

	public Venta(int anio, int mes, string departamento, int numventas)
	{
		this.Anio = anio;
		this.Mes = mes;
		this.Departamento = departamento;
		this.NumVentas = numventas;
	}

}
