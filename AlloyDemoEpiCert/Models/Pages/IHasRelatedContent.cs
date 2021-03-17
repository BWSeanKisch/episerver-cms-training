using EPiServer.Core;

namespace AlloyDemoEpiCert.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
