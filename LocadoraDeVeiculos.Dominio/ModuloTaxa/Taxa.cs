using LocadoraDeVeiculos.Dominio.ModuloLocacao;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxa;

public class Taxa : EntidadeBase
{
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public TipoCobrancaEnum TipoCobranca { get; set; }
    public List<Locacao>? Locacoes { get; set; }

    protected Taxa()
    {
        Locacoes = new();
    }

    public Taxa(string nome, decimal valor, TipoCobrancaEnum tipoCobranca) : this()
    {
        Nome = nome;
        Valor = valor;
        TipoCobranca = tipoCobranca;
    }

    public override List<string> Validar()
    {
        List<string> erros = [];

        if (Nome.Length < 3)
            erros.Add("O nome precisa conter ao menos 3 caracteres");

        if (Valor < 1.0m)
            erros.Add("O valor precisa ser ao menos 1");

        return erros;
    }

    public decimal CalcularValor(int quantidadeDeDias)
    {
        if (TipoCobranca == TipoCobrancaEnum.Diaria)
            return Valor * quantidadeDeDias;

        return Valor;
    }
}