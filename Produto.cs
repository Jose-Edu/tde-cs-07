public class Produto() {

    public string nome;
    public int quantidade;
    public double preco;

    public void AdicionarEstoque(int quant) {

        if (quant <= 0) {
            Console.WriteLine("ERRO: Impossível adicionar um valor negativo! Digite um valor válido!");
        }
        else {

            quantidade += quant;
            Console.WriteLine("Quantidade adcionada com sucesso!");

        };
    }

    public void RemoverEstoque(int quant) {

        if (quant <= quantidade && quant > 0) {

            quantidade -= quant;
            Console.WriteLine("Quantidade removida com sucesso!");
            
        }
        else if (quant > quantidade) {

            Console.WriteLine("ERRO: Impossível remover um valor maior que o total em estoque!");

        }
        else {

            Console.WriteLine("ERRO: Impossível remover um valor negativo! Digite um valor válido!");

        };
    }

}