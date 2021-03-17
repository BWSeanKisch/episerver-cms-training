using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing;

namespace AlloyTraining.Business.SelectionFactories
{
    public class ThemeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new List<SelectItem>
            {
                new SelectItem {Value = "theme1", Text = "Theme 1"},
                new SelectItem {Value = "theme2", Text = "Theme 2"},
                new SelectItem {Value = "theme3", Text = "Theme 3"},
            };
        }
    }
}