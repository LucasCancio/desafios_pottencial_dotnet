namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria)
            : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(Aplicativo app)
        {
            try
            {
                Console.WriteLine($"Instalando o app {app.Nome} na AppStore...");
                GravarNaMemoria(app.Memoria);
                Console.WriteLine("Aplicativo instalado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao instalar o aplicativo: {ex.Message}");
            }
        }
    }
}