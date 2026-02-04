namespace MetasMermer.Services.Abouts;

public record AboutDto
{
    public List<string> ImageLink { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
