namespace WebApplication1.Model
{
    public class Film : EFModel
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Budget { get; set; }
        public string Director { get; set; }
    }
}
