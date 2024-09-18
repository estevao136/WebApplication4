namespace WebApplication4.Class
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Pessoa(string nome, string cpf, double peso, double altura)
        {
            Nome = nome;
            Cpf = cpf;
            Peso = peso;
            Altura = altura;
        }
    }

}
