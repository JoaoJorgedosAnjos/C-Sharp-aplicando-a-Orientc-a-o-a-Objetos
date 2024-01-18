class BanckAccount
{
    public int AccountId { get; set; }
    public string User { get; set; }
    public float Balance { get; set; }
    public string Password { get; set; }
}

class Car
{
    public void SpeedUp()
    {
        Console.WriteLine("Carro está acelerando");
    }
    public void Breke()
    {
        Console.WriteLine("Carro freiou");
    }
    public void Honk()
    {
        Console.WriteLine("Carro está buzinando");
    }

    public string Fabricante { get; set; }
    public string Modelo { get; set; }

    public int Ano
    {
        get => Ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                Ano = value;
            }
        }
    }
    public int QuantidadePortas { get; set; }

    public string DetailCarDescription => $"Fabricante: {Fabricante}, modelo: {Modelo}, ano: {Ano}";

}

class Produto
{
    private double preco;
    private int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
                preco = value;
            else
                preco = 10;
        }
    }

    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
                estoque = value;
            else
                estoque = 0;

        }
    }

    public string DescricaoProduto => $"{this.Nome} {this.Marca} - {this.Preco}";

}
