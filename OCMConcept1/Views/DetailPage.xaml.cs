using OCMConcept1.ViewModels;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls;
using Microsoft.Toolkit.Uwp;

namespace OCMConcept1.Views
{
    public sealed partial class DetailPage : Page
    {
        public DetailPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Disabled;
        }

        private void TextBlock_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}

