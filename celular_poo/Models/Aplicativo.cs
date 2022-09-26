namespace DesafioPOO.Models
{
    public class Aplicativo
    {
        public Aplicativo(string nome, int memoria)
        {
            Nome = nome;
            Memoria = memoria;
        }

        public string Nome { get; private set; }
        public int Memoria { get; private set; }

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var app = obj as Aplicativo;
            return app.Nome.Equals(this.Nome, StringComparison.InvariantCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
