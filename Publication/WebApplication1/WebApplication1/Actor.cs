using WebApplication1.Model;

namespace WebApplication1
{
    public class Actor : EFModel
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Age { get; set; }
        public string Rating { get; set; }
    }
}
