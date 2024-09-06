using LocadoraDeVeiculos.Infra.Orm.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxa;
public interface IRepositorioTaxa : IRepositorio<Taxa>
{
    List<Taxa> SelecionarMuitos(List<int> idsTaxasSelecionadas);
}
