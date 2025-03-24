namespace EF_Core_Survivor.Entities;

public class CategoryEntity : BaseEntity
{

    public string Name { get; set; }

    public List<CompetitorEntity> Competitors { get; set; }


}
