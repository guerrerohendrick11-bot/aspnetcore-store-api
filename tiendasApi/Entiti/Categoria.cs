namespace tiendasApi.Entiti
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        ICollection<Productos> Productos { get; set; }
    }
    
}
