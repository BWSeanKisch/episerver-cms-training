using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Standard", GUID = "36a91870-96a2-44a3-99a5-938afc7d4df9", Description = "A standard page", GroupName = SiteGroupNames.Common)]
    [SitePageIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) }, Exclude = new [] {typeof(ProductPage)})]

    public class StandardPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual XhtmlString MainBody { get; set; }

    }
}