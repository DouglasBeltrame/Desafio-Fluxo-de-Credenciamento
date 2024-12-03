internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escolha e Escreva o produto de sua prefêrencia: TAE, TRE, TKE, TF");
        string produto = Console.ReadLine();

        Console.WriteLine("\nDigite o seu CNPJ: ");
        string cnpj = Console.ReadLine();

        Console.WriteLine("\nDigite sua Razão Social: ");
        string razaoSocial = Console.ReadLine();

        Console.WriteLine("\nDigite o seu Nome Fantasia: ");
        string nomeFantasia = Console.ReadLine();

        Console.WriteLine("\nDigite o seu Endereço: ");
        string endereco = Console.ReadLine();

        Console.WriteLine("\nInforme o seu banco: ");
        string banco = Console.ReadLine();

        Console.WriteLine("\nDigite sua Agência: ");
        int agencia = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite número de sua Conta: ");
        int conta = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o Adquirente: ");
        string adquirente = Console.ReadLine();

        Console.WriteLine("\nInforme sua Filiação: ");
        string filiacao = Console.ReadLine();

        switch (produto)
        {
            case "TAE":
                Console.WriteLine("\nO Valor de sua taxa será de: R$ 1,00 e seu Serviço será o: Serpar Automático");
                break;
            case "TRE":
                Console.WriteLine("\nO Valor de sua taxa será de: R$ 3,00 e seu Serviço será o: Cuponagem");
                break;
            case "TF":
                Console.WriteLine("\nO Valor de sua taxa será de: R$ 2,00 e seu Serviço será o: Serpar Eventual");
                break;
            case "TKE":
                Console.WriteLine("\nO Valor de sua taxa será de: R$ 0,00 e seu Serviço será o: Sem Serviço");
                break;
            default:
                Console.WriteLine("\nProduto inválido. Por favor, escolha um produto válido.");
                break;
        }

        Console.WriteLine("\nAqui estão todas as suas informações selecionadas: ");
        Console.WriteLine("Produto:" + produto);
        Console.WriteLine("CNPJ: " + cnpj);
        Console.WriteLine("Razão Social" + razaoSocial);
        Console.WriteLine("Nome Fantasia" + nomeFantasia);
        Console.WriteLine("Endereço" + endereco);
        Console.WriteLine("Banco" + banco);
        Console.WriteLine("Agencia" + agencia);
        Console.WriteLine("Conta" + conta);
        Console.WriteLine("Adquirente" + adquirente);
        Console.WriteLine("Filiação" + filiacao);      
        Console.WriteLine(produto);


    }
}