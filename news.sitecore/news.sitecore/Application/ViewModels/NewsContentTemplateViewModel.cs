using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace news.sitecore.Application.ViewModels
{
    public class NewsContentTemplateViewModel
    {
        public Item Item { get; set; }
        public GroupedDroplinkField newsTypeValue { get; set; }
    }
}