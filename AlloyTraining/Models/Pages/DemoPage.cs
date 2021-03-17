using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Business.Validation;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Demo Page",
        GUID = "3064f2cc-98ce-4d30-9a1c-34acff7a7127",
        Description = "A page for demoing simple page types.")]
    public class DemoPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
        [OperaYear]
        public virtual int OperaWritten { get; set; }
        [StringLength(12, MinimumLength = 5)]
        public virtual string MyText { get; set; }

        public virtual bool MyBoolean { get; set; }
        public virtual DateTime? MyDateTime { get; set; }
        public virtual double? MyRealNumber { get; set; }
        [EmailAddress]
        public virtual string Email { get; set; }
        [Range(18, 65)]
        public virtual int? MyWholeNumber { get; set; }

        // this will thrown an exception
        //public virtual float? MyFloatNumber { get; set; }

        public virtual Url MyLink { get; set; }
        public virtual LinkItemCollection MyLinks { get; set; }
        public virtual CategoryList MyExtraCategories { get; set; }
        public virtual PageType MyPageType { get; set; }

        public virtual ContentReference MyContent { get; set; }
        public virtual ContentReference MyPage { get; set; }
        public virtual ContentArea MyContentArea { get; set; }
        [AllowedTypes(AllowedTypes = new[] { typeof(StartPage) })]
        public virtual IList<ContentReference> MyContentList { get; set; }

    }
}