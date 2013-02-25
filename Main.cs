using System;

namespace Practica2
{
	class Principal
	{
		public int horas, minutos, segundos;
		public void muestraMenu(){
			Console.WriteLine("Menu");
			Console.WriteLine("1 Reloj");
			Console.WriteLine("2 Cronometro");
		}

		public string agregarceros(int numero){
			string numeroConFormato = "";
			if(numero < 10){
				numeroConFormato = "0";
			}
			
			numeroConFormato += numero;
			return numeroConFormato;
		}
		private void obtenHoraLocal(){

			this.horas = DateTime.Now.Hour;
			this.minutos = DateTime.Now.Minute;
			this.segundos = DateTime.Now.Second;
			Console.WriteLine(agregarceros(horas) + ":" + agregarceros(minutos) + ":" + agregarceros(segundos));
			System.Threading.Thread.Sleep(1000);
			Console.Clear();
		}

		public void Reloj()
		{
			Console.WriteLine("Reloj");
			while(true){
			obtenHoraLocal();

			}
			}

		public void cronometro ()
		{
			Console.WriteLine ("Cronometro");
			this.horas = 0;
			this.minutos = 0;
			this.segundos = 0;
			while (true) {
				Console.WriteLine(agregarceros(horas) + ":" + agregarceros(minutos) + ":" + agregarceros(segundos));
				System.Threading.Thread.Sleep(1000);
				Console.Clear();
				segundos++;
				if (segundos > 59){
					segundos = 0;
					minutos++;
				}
				if (minutos > 59){
					minutos = 0;
					horas++;
				}
			}
		}

		public void leerEntrada(){
			int opcion = int.Parse(Console.ReadLine());
			Principal reloj = new Principal();
			if(opcion == 1){
				reloj.Reloj();
			}else{
				reloj.cronometro();
			}
		}
		
		public static void Main (string[] args)
		{
			
			Principal programa = new Principal();
			programa.muestraMenu();
			programa.leerEntrada();
		}
	}
}
