using Sitecore.Data.Items;
using Sitecore.Links;
using System;

namespace news.sitecore.Extensions
{
    public static class ItemExtensions
    {
        public static string Url(this Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            return LinkManager.GetItemUrl(item);
        }
    }
}
