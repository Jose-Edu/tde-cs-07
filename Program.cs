bool sysOn = true;
Produto produto = new Produto();

while (sysOn) {

    Console.Clear();

    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Definir dados do produto");
    Console.WriteLine("2 - Adicionar ao estoque");
    Console.WriteLine("3 - Remover do estoque");
    Console.WriteLine("4 - Exibir detalhes do produto");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("");

    string op = Console.ReadLine();

    switch(op) {

        case "1":

            Console.Clear();

            Console.WriteLine("Digite o nome do produto:");
            produto.nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade inicial em estoque do produto:");
            produto.quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto");
            produto.preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.ReadKey();

            break;

        case "2":

            Console.Clear();

            try {
                Console.WriteLine("Digite o valor a ser acrecentado:");
                produto.AdicionarEstoque(Convert.ToInt32(Console.ReadLine()));
            }
            catch(System.Exception) {

                Console.WriteLine("ERRO: Digite um valor válido!");

            };

            Console.WriteLine($"Quantidade atual em estoque: {produto.quantidade}");
            Console.ReadKey();

            break;

        case "3":

            Console.Clear();

            try {
                Console.WriteLine("Digite o valor a ser removido:");
                produto.RemoverEstoque(Convert.ToInt32(Console.ReadLine()));
            }
            catch(System.Exception) {

                Console.WriteLine("ERRO: Digite um valor válido!");

            };

            Console.WriteLine($"Quantidade atual em estoque: {produto.quantidade}");
            Console.ReadKey();

            break;

        case "4":
            Console.Clear();

            Console.WriteLine($"Nome do produto: {produto.nome}");
            Console.WriteLine($"Preço do produto: {produto.preco}");
            Console.WriteLine($"Quantidade em estoque: {produto.quantidade}");
            Console.WriteLine($"Valor total em estoque: {produto.preco*produto.quantidade}");

            Console.ReadKey();

            break;

        case "5":
            Console.Clear();
            Console.WriteLine("Saindo do sistema...");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("ERRO: Opção inválida!");
            Console.ReadKey();
            break;

    }

};