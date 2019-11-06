using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using exam_uwp.Entities;
using exam_uwp.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace exam_uwp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchForm : Page
    {
        private ContactModel _contactModel;
        public SearchForm()
        {
            this.InitializeComponent();
        }

        public void ButtonSearch_OnClick(object sender, RoutedEventArgs e)
        {
            var name = this.Name.Text;
            //var phoneNumber = this.PhoneNumber.Text;
            var contact = this._contactModel.SelectItem(name);
            Name.Text = contact.Name;
            PhoneNumber.Text = contact.PhoneNumber;
        }
    }
}
