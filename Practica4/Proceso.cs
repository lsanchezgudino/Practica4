using System;
using System.Collections;

namespace Practica4
{
	public class Proceso
	{
		public Hashtable tabla;
		public Proceso ()
		{
			this.tabla = new Hashtable();
		}
		
		public void capturar(){
			
			for (int i=0; i<4; i++){
				Persona p=new Persona();
				Console.Clear();
				Console.WriteLine("ingrese su codigo");
				p.codigo=Console.ReadLine();
				Console.WriteLine("ingrese su nombre");
				p.codigo=Console.ReadLine();
				Console.WriteLine("ingrese su telefono");
				p.codigo=Console.ReadLine();
				Console.WriteLine("ingrese su facebook");
				p.codigo=Console.ReadLine();
				this.                                            tabla.Add(p.codigo, p);
			}
		}
	}
}

