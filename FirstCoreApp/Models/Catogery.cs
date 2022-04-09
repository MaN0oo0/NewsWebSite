namespace FirstCoreApp.Models
{
    public class Catogery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }

        public List<News> News { get; set; }
    }
}
