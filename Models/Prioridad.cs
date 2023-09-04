using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

public class Prioridad
{
    public int PrioridadId { get; set; }

    [Required(ErrorMessage = "La descripción es obligatoria.")]
    [StringLength(50, ErrorMessage = "La descripción no debe tener más de 50 caracteres.")]
    [Remote(action: "IsDescripcionUnica", controller: "Prioridades", AdditionalFields = nameof(PrioridadId))]
    public string Descripcion { get; set; }

    [Required(ErrorMessage = "Los días de compromiso son obligatorios.")]
    [Range(1, int.MaxValue, ErrorMessage = "Los días de compromiso deben ser un número mayor que 0.")]
    public int DiasCompromiso { get; set; }
}
