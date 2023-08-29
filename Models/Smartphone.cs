namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero;
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }
         public void mostrarNumero(){
            Console.WriteLine($"Numero: {Numero}");
        }
        public void mostrarModelo(){
            Console.WriteLine($"Modelo: {Modelo}");
        }
        public void mostrarIMEI(){
            Console.WriteLine($"IMEI: {IMEI}");
        }
        public void mostrarMemoria(){
            Console.WriteLine($"Memoria: {Memoria}");
        }
        

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}