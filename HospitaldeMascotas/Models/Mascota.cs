namespace HospitaldeMascotas.Models
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public string? NombreMascota { get; set; }
        public string? Raza { get; set; }
        public int Edad { get; set; }
        public string? Sexo { get; set; }
        public string? Color { get; set; }
        public string? NombrePropietario { get; set; }
        public string? CedulaPropietario { get; set; }
        public string? DireccionPropietario { get; set; }
        public string? TelefonoPropietario { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public bool Activo { get; set; }
    }
}
