namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        public string Modelo { get; private set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }

        public List<Aplicativo> Aplicativos { get; private set; }
        public int MemoriaUsada { get => Aplicativos.Sum(x => x.Memoria); }

        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
            Numero = numero;
            Aplicativos = new List<Aplicativo>();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(Aplicativo app);

        protected void GravarNaMemoria(int memoriaParaGravar)
        {
            if (MemoriaUsada + memoriaParaGravar > Memoria)
                throw new Exception("Não há memoria o suficiente para instalar esse aplicativo.");
        }
    }
}