using Xamarin.CommunityToolkit.ObjectModel;

namespace GrouppedListReorder.ViewModels
{
    public class ItemViewModel : ObservableObject
    {
        public string Category { get; set; }
        public string Title { get; set; }
    }
}