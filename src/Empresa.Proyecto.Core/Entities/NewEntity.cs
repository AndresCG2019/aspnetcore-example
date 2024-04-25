namespace Empresa.Proyecto.Core.Entities
{
    /// <summary>
    /// Ejemplo de entidad compleja, como una entidad principal en dominio 
    /// con multiples campos e interacciones con otras entidades mas simples
    /// </summary>
    public class NewEntity : BaseEntity
    {
        public string Nombre { get; set; } = null!;
        public SimpleEntity Opcion { get; set; } = null!;
    }
}
