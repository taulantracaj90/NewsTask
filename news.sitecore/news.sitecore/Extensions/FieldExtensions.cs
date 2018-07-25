using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using news.sitecore.Domain.Sitecore;
using Sitecore;
using Sitecore.Resources.Media;

namespace news.sitecore.Extensions
{
    public static class FieldExtensions 
    {
        public static string GetImageUrl(Item item)
        {
            var imageUrl = string.Empty;

            ImageField imageField = ((ImageField)item.Fields[Templates.StandardContent.Fields.Image]);
            if (imageField?.MediaItem != null)
            {
                var image = new MediaItem(imageField.MediaItem);
                imageUrl = StringUtil.EnsurePrefix('/', MediaManager.GetMediaUrl(image));
            }
            return imageUrl;
        }
    }
}