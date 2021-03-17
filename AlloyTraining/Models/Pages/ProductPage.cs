using AlloyTraining.Business.SelectionFactories;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Product", GUID = "7e6d797c-7173-45b1-ab58-0e2a37d65c91", Description = "A product page", GroupName = SiteGroupNames.Specialized)]
    [SiteCommerceIcon]
    public class ProductPage : StandardPage
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            Theme = "theme1";
        }

        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        [Display(GroupName = SystemTabNames.Content, Order = 310)]
        public virtual string Theme { get; set; }

        [CultureSpecific]
        [Display(Name = "Unique selling points.", GroupName = SystemTabNames.Content, Order = 320)]
        [Required]
        public virtual IList<string> UniqueSellingPoints { get; set; }
    }
}