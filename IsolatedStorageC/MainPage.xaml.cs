using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IsolatedStorageC.Resources;
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;

namespace IsolatedStorageC
{
    public partial class MainPage : PhoneApplicationPage
    {

        CameraCaptureTask cameraCaptureTask;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            cameraCaptureTask = new CameraCaptureTask();
            cameraCaptureTask.Completed += new EventHandler<PhotoResult>(cameraCaptureTask_Completed);

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            if (!IsolatedStorageSettings.ApplicationSettings.Contains("userdata"))
            {
                settings.Add("userdata", txtInput.Text);

            }

            else
            {
                IsolatedStorageSettings.ApplicationSettings["userdate"] = txtInput.Text;
            }
            settings.Save();

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("userdata"))
            {
                IsolatedStorageSettings.ApplicationSettings.Remove("userdata");
                txbView.Text = "";
            }

        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("userdata"))
            {
                txbView.Text = IsolatedStorageSettings.ApplicationSettings["userdata"].ToString();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cameraCaptureTask.Show();
        }
        void cameraCaptureTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                MessageBox.Show(e.ChosenPhoto.Length.ToString());


            }

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}