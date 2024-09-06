namespace LocadoraDeVeiculos.Dominio.ModuloCombustivel;
public interface IRepositorioCombustivel
{
    void GravarConfiguracao(ConfiguracaoCombustivel configuracaoCombustivel);
    ConfiguracaoCombustivel? ObterConfiguracao();
}
