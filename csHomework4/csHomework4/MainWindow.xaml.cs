using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace csHomework4
{

    public partial class MainWindow : Window
    {
        bool changeBool = false;
        bool changeCountry = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UxZip_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex usZip = new Regex("^([0-9]{5}$)|^([0-9]{5})-([0-9]{4}$)$");
            Regex cdnCode = new Regex("^([a-zA-Z][0-9]){3}$");
            Regex startWith = new Regex("^[0-9]");

            changeCountry = startWith.IsMatch(uxZip.Text);

            if (changeCountry)
            {
                changeBool = usZip.IsMatch(uxZip.Text);
                if (changeBool)
                {
                    uxSubmit.IsEnabled = true;
                }
                else uxSubmit.IsEnabled = false;
            }
            else
            {
                changeBool = cdnCode.IsMatch(uxZip.Text);
                if (changeBool)
                {
                    uxSubmit.IsEnabled = true;
                }
                else uxSubmit.IsEnabled = false;
            }
        }
    }
}
