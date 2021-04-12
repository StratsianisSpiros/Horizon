
namespace Entities.UtilityModels
{
    public class PagedView
    {
        public int CurrentIndex { get; set; }
        public int CurrentPage { get; set; }
        public int MaxIndex { get; set; }
        public string Search { get; set; }
    }
}
