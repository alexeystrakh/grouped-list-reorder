using Xamarin.CommunityToolkit.ObjectModel;

namespace GrouppedListReorder.ViewModels
{
    public class ItemViewModel : ObservableObject
    {
        public string Category { get; set; }
        public string Title { get; set; }

        private bool _isBeingDragged;
        public bool IsBeingDragged
        {
            get { return _isBeingDragged; }
            set { SetProperty(ref _isBeingDragged, value); }
        }

        private bool _isBeingDraggedOver;
        public bool IsBeingDraggedOver
        {
            get { return _isBeingDraggedOver; }
            set { SetProperty(ref _isBeingDraggedOver, value); }
        }
    }
}