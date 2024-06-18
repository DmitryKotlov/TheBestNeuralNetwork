namespace TheBestWebInterfaceRazorPages.Services
{
    public class PredictDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Probability { get; set; }
    }
}