using MvcTask.DataAccsessLayer.Entity;

namespace MvcTask.DataAccsessLayer
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> products { get; set;} = new List<Product>();


    }
}
