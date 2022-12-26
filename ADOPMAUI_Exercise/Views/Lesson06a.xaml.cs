using ADOPMAUI_Exercise.ViewModels;

namespace ADOPMAUI_Exercise.Views
{

    public partial class Lesson06a : ContentPage
    {
        public Lesson06a()
        {
            InitializeComponent();
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                Lesson06aViewModel pageData = args.SelectedItem as Lesson06aViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Navigation.PushAsync(page);
            }
        }
    }
}