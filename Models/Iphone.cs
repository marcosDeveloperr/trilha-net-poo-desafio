namespace DesafioPOO.Models
{
    // Implementado!!!!
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria){}

        //Imlementado!!!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
           
        }
    }
}