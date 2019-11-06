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
    public sealed partial class FormContact : Page
    {
        private ContactModel _contactModel;
        public FormContact()
        {
            this.InitializeComponent();
            this._contactModel = new ContactModel();

        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(PhoneNumber.Text))
            {
                Contact contact = new Contact()
                {
                    Name = this.Name.Text,
                    PhoneNumber = this.PhoneNumber.Text
                };
                this._contactModel.Insert(contact);
                Name.Text = string.Empty;
                PhoneNumber.Text = string.Empty;
            }
        }
    }
}
