﻿using LocadoraDeVeiculos.Dominio.ModuloAutenticacao;

namespace LocadoraDeVeiculos.Infra.Orm.Compartilhado;
public abstract class EntidadeBase
{
    public int Id { get; set; }
    public int EmpresaId { get; set; }
    public Usuario? Empresa { get; set; }
    public abstract List<string> Validar();
}
