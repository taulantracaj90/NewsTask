using Sitecore.Data;

namespace news.sitecore.Domain.Sitecore
{
    public struct Templates
    {
        public struct StandardContent
        {
            public static ID ID = new ID("{66C00BCC-DF6D-4D5B-8340-D0A570C3B3B8}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{7E0AC5FC-E498-4CFC-BBF9-0CF05B4D4D81}");
                public const string Title_FieldName = "ArticleDate";

                public static readonly ID Image = new ID("{E210CA1F-F476-49B6-BD57-44A4632D8E55}");
                public const string Image_FieldName = "NewsType";
            }
        }
        public struct NewsContent
        {
            public static ID ID = new ID("{F94C912A-F95E-4B6F-BC69-AB1ADEEB6D6A}"); //{6CEC6BA9-11D4-4E4C-A35F-0FDE77036B3F}");
            public struct Fields
            {
                public static readonly ID ArticleDate = new ID("{DFEF1651-2EF0-4F54-B798-8B6189DC19C7}");
                public const string Date_FieldName = "ArticleDate";

                public static readonly ID NewsType = new ID("{A704637F-F576-444D-A202-98CEE6B14260}");
                public const string NewsType_FieldName = "NewsType";

                public static readonly ID Abstract = new ID("{670DFB00-2ACD-4B3A-9D17-5B977191DB6B}");
                public const string Abstract_FieldName = "Abstract";

                public static readonly ID Content = new ID("{846E3906-A6B4-45C9-A2A2-0B0E16C7F94C}");
                public const string Content_FieldName = "Content";
            }
        }
        public struct NewsType
        {
            public static ID ID = new ID("{995A73CA-DA9F-4251-A19B-C3149C33A3DD}");
            public struct Fields
            {
                public static readonly ID Keyword = new ID("{FFAC7E6E-E171-4212-B72F-B4ACA095AEFD}");
                public const string Keyword_FieldName = "Keyword";
            }
        }
        public struct NewsContentTemplate
        {
            public static ID ID = new ID("{96A15783-5E3A-49A5-AD21-E45DDC938C33}");
        }
        public struct NewsTypeTemplate
        {
            public static ID ID = new ID("{FA88D7EF-DA44-4AB0-8790-AACE61829956}");
        }
        public struct NewsTileComponent
        {
            public static ID ID = new ID("{EC0EA841-D552-49E0-A1D5-CD82496A06A8}");
            public struct Fields
            {
                public static readonly string NewsType = "News Type";
            }
        }
    }
}