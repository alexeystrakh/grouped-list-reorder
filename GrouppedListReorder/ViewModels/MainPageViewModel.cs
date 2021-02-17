using System;
using System.Collections.ObjectModel;
using Xamarin.CommunityToolkit.ObjectModel;

namespace GrouppedListReorder.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<ItemViewModel> _items = new ObservableCollection<ItemViewModel>();
        public ObservableCollection<ItemViewModel> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public MainPageViewModel()
        {
            Items.Add(new ItemViewModel { Category = "Category 1", Title = "Item 1" });
            Items.Add(new ItemViewModel { Category = "Category 1", Title = "Item 2" });
            Items.Add(new ItemViewModel { Category = "Category 2", Title = "Item 3" });
            Items.Add(new ItemViewModel { Category = "Category 2", Title = "Item 4" });
            Items.Add(new ItemViewModel { Category = "Category 2", Title = "Item 5" });
            Items.Add(new ItemViewModel { Category = "Category 2", Title = "Item 6" });
            Items.Add(new ItemViewModel { Category = "Category 3", Title = "Item 7" });
        }
    }
}