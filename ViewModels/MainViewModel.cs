using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Xpf.LayoutControl;
using DevExpress.XtraEditors;
using OrderEntryScreenCustomization.Models;
using System.Collections.ObjectModel;

namespace OrderEntryScreenCustomization.ViewModels
{
    [GenerateViewModel]
    public partial class MainViewModel
    {
        //public FlowLayoutControl FlowLayoutControl = new FlowLayoutControl();
        private bool isAllowMoveCheck = false;
        public virtual ObservableCollection<ItemData> HiddenFields { set; get; }

        public MainViewModel()
        {
            HiddenFields = new ObservableCollection<ItemData>
            {
                new ItemData { Name = "Symbol", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "Quantity", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "Price", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "Account", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "Destination", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "Text...", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "Price Type", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "Stop Px", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "TIF", Value = "", Type = "TextEdit", IsVisible = true },
                new ItemData { Name = "GTD Date", Value = "", Type = "TextEdit", IsVisible = true }
            };

        }
        public virtual bool IsAllowMoveCheck { get => isAllowMoveCheck; set => isAllowMoveCheck = value; }
    }
}
