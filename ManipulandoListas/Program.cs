namespace ManipulandoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            List<Pessoa> listaPessoas = new List<Pessoa>();
            while (true)
            {
                Console.WriteLine("Cadastro de pessoas: ");
                Console.WriteLine("Digite 1 para cadastrar pessoas");
                Console.WriteLine("Digite 2 para mostrar as pessoas da lista");
                op = int.Parse(Console.ReadLine());
                if (op == 1) 
                {
                    Pessoa p = new Pessoa();
                    Console.WriteLine("Digite o ID da pessoa: ");
                    p.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome da pessoa: ");
                    p.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o email da pessoa: ");
                    p.Email = Console.ReadLine();
                    listaPessoas.Add(p);
                }
                else if (op == 2)
                {
                    /*for(int i = 0; i < listaPessoas.Count; i++) 
                    {
                        Console.Write("ID: "+listaPessoas[i].Id);
                        Console.Write(" - Nome: " + listaPessoas[i].Nome);
                        Console.WriteLine(" - E-mail: " + listaPessoas[i].Email);
                    }*/
                    foreach(Pessoa pessoa in listaPessoas) 
                    {
                        Console.Write("ID: " + pessoa.Id);
                        Console.Write(" - Nome: " + pessoa.Nome);
                        Console.WriteLine(" - E-mail: " + pessoa.Email);
                    }
                }
                else { Console.WriteLine("Digite uma operação válida!"); }
            }



        }
    }
}