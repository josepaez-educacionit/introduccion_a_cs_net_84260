using System.ComponentModel.DataAnnotations;

namespace InterfazGraficaMVC_SQL.Entities;

public partial class Persona
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
    public string Nombre { get; set; } = null!;

    [Display(Name = "Apellido")]
    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [StringLength(100, ErrorMessage = "El apellido no puede superar los 100 caracteres.")]
    public string Apellido { get; set; } = null!;

    [Display(Name = "Edad")]
    [Required(ErrorMessage = "La edad es obligatoria.")]
    [Range(0, 120, ErrorMessage = "La edad debe estar entre 0 y 120 años.")]
    public int Edad { get; set; }

    [Display(Name = "Correo electrónico")]
    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido.")]
    [StringLength(200, ErrorMessage = "El correo electrónico no puede superar los 200 caracteres.")]
    public string Email { get; set; } = null!;
}
