﻿using System.ComponentModel.DataAnnotations;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxa;

public enum TipoCobrancaEnum
{
    [Display(Name = "Diária")]
    Diaria,
    Fixa
}