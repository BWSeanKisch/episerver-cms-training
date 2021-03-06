using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;
using EPiServer.Security;

namespace AlloyTraining
{
    [GroupDefinitions]
    public static class SiteTabNames
    {
        [Display(Order = 10)]
        [RequiredAccess(Access = AccessLevel.Edit)]
        public const string SEO = "SEO";

        [Display(Order = 20)]
        [RequiredAccess(Access = AccessLevel.Administer)]
        public const string SiteSettings = "Site Settings";
    }
}