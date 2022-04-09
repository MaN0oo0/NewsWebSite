using System.ComponentModel.DataAnnotations.Schema;

namespace FirstCoreApp.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime date { get; set; }
        public string Image { get; set; }
        public string Topic { get; set; }

        [ForeignKey("Catogery")]
        public int CatogeryId { get; set; }
        public Catogery Catogery { get; set; }
    }
}
