﻿using System.Web;
using Our.Umbraco.Ditto;

namespace DitFlo.ViewModels
{
    public class NewsItemViewModel
    {
        [UmbracoProperty("Title", "Name")]
        public string Title { get; set; }

        public string Image { get; set; }

        public HtmlString BodyText { get; set; }
    }
}
