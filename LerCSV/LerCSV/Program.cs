namespace Contatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lendo o CSV e mostrando no console!!!");
            LerCSV();
            Console.WriteLine("***Fim!!!***");
            Console.ReadLine();
            


        }
        static void LerCSV()
        {
            var linhas = File.ReadAllLines("Contatos.csv");
            var lista = new List<Contato>();
            foreach (var linha in linhas)
            {
                var valores = linha.Split(',');
                var Contato = new Contato(){Nome = valores[0], CPF = valores[1]};
                lista.Add(Contato);
            }
            lista.ForEach(x => Console.WriteLine($"{x.Nome}\t{x.CPF}"));
        }
    }
    public class Contato
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}