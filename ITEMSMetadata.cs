using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ASTEC.Models
{
    [MetadataType(typeof(ITEM.Metadata))]
    public partial class ITEM
    {
        private sealed class Metadata
        {
            [Display(Name = "ITEM_ID")]
            public int ITEM_ID { get; set; }

            [Display(Name = "MENU_ID")]
            public int MENU_ID { get; set; }

            [Display(Name = "ITEM_TITLE")]
            public string ITEM_TITLE { get; set; }

            [Display(Name = "ITEM_SUB_TITLE")]
            public string ITEM_SUB_TITLE { get; set; }

            [AllowHtml]
            [Display(Name = "ITEM_CONTENT")]
            public string ITEM_CONTENT { get; set; }

            [Display(Name = "ITEM_IMAGE")]
            public string ITEM_IMAGE { get; set; }

            [Display(Name = "ITEM_META_KEYWORD")]
            public string ITEM_META_KEYWORD { get; set; }

            [Display(Name = "ITEM_META_DESCRIPTION")]
            public string ITEM_META_DESCRIPTION { get; set; }

            [Display(Name = "ITEM_SLUG")]
            public string ITEM_SLUG { get; set; }

            [Display(Name = "ITEM_VIEW_COUNT")]
            public Nullable<int> ITEM_VIEW_COUNT { get; set; }

            [Display(Name = "ITEM_LIKE_COUNT")]
            public Nullable<int> ITEM_LIKE_COUNT { get; set; }

            [Display(Name = "CREATED_DATE")]
            public Nullable<DateTime> CREATED_DATE { get; set; }

            [Display(Name = "UPDATED_DATE")]
            public Nullable<DateTime> UPDATED_DATE { get; set; }

            [Display(Name = "ADMIN_CREATED")]
            public string ADMIN_CREATED { get; set; }

            [Display(Name = "ADMIN_UPDATED")]
            public string ADMIN_UPDATED { get; set; }

            [Display(Name = "ITEM_NOTES")]
            public string ITEM_NOTES { get; set; }

            [Display(Name = "ITEM_STATUS")]
            public Nullable<byte> ITEM_STATUS { get; set; }

            [Display(Name = "ITEM_ISDELETE")]
            public Nullable<bool> ITEM_ISDELETE { get; set; }
        }
    }
}