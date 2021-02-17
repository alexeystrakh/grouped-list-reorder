using System;
using System.Diagnostics;
using GrouppedListReorder.ViewModels;
using Xamarin.Forms;

namespace GrouppedListReorder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void DragGestureRecognizer_DragStarting(Object sender, DragStartingEventArgs e)
        {
            var label = (Label)((Element)sender).Parent;
            Debug.WriteLine($"DragGestureRecognizer_DragStarting [{label.Text}]");

            e.Data.Properties["Label"] = label;

            //e.Handled = true;
        }

        private void DropGestureRecognizer_Drop(Object sender, DropEventArgs e)
        {
            var label = (Label)((Element)sender).Parent;
            var dropLabel = (Label)e.Data.Properties["Label"];
            if (label == dropLabel)
                return;

            Debug.WriteLine($"DropGestureRecognizer_Drop [{dropLabel.Text}] => [{label.Text}]");

            var sourceContainer = (Grid)dropLabel.Parent;
            var targetContainer = (Grid)label.Parent;
            sourceContainer.Children.Remove(dropLabel);
            targetContainer.Children.Remove(label);
            sourceContainer.Children.Add(label);
            targetContainer.Children.Add(dropLabel);

            e.Handled = true;
        }

        private void DragGestureRecognizer_DragStarting_Collection(System.Object sender, Xamarin.Forms.DragStartingEventArgs e)
        {

        }

        private void DropGestureRecognizer_Drop_Collection(System.Object sender, Xamarin.Forms.DropEventArgs e)
        {
            // We handle reordering login in our view model
            e.Handled = true;
        }
    }
}
