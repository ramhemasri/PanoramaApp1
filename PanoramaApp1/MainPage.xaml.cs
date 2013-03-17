using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
namespace PanoramaApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            pushPano.DefaultItem = pushPano.Items[1];
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }      

     

        private void list_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            /*StackPanel x = new StackPanel();
            TextBlock y = new TextBlock();
            x = (StackPanel)list.SelectedItem;
            string[] properties = new string[4];
            int i = 0;
            foreach (var child in x.Children)
            {
                
                if (child.GetType().ToString() == "System.Windows.Controls.TextBlock")
                {

                    y = (TextBlock)child;
                    properties[i] = y.Text;
                    MessageBox.Show(properties[i]);
                    i++;

                }
            }*/
            NavigationService.Navigate(new Uri("/Study.xaml", UriKind.Relative));
        }
    }
}