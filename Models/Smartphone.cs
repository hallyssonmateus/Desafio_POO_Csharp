namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //Propriedades
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }
        

        //Construtor Padrão
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        //Metodos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void MensagemSistema()
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine($"Sincronizando contados do numero {Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}