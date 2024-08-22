namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public string Marca {get;} = "Nokia";
        //Construtor
        public  Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no modelo {Marca}!");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
            Console.WriteLine("\n");
        }
    }
}