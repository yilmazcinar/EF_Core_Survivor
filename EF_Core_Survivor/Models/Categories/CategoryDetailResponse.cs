using EF_Core_Survivor.Models.Competitors;

namespace EF_Core_Survivor.Models.Categories;

public class CategoryDetailResponse
{

    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public List<CompetitorListResponse> Competitors { get; set; }
}
