using LocadoraDeVeiculos.Dominio.ModuloVeiculo;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoVeiculos;
public class GrupoVeiculos : EntidadeBase
{
	public string Nome { get; set; }
	public List<Veiculo> Veiculos { get; set; } = [];

	protected GrupoVeiculos() { }
	public GrupoVeiculos(string nome)
	{
		Nome = nome;
	}

	public override List<string> Validar()
	{
		List<string> erros = new List<string>();

		if (Nome.Length < 3)
			erros.Add("O nome é obrigatório");

		return erros;
	}
}
