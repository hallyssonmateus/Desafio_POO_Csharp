namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    
    {   
        public string Marca {get;} = "Iphone";
        //Construtor
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no {Marca}!");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
            Console.WriteLine("\n");
        }
    }
}