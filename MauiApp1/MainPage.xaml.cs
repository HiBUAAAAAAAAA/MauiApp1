namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        List<string> list = new List<string>() { "Apple", "banana", "orange", "Melon", "Peach" };
        public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            DisplayAlert("Select", e.SelectedItem.ToString(), "ok");
            ((ListView)sender).SelectedItem = null;
        }
    }
}