using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Data;
using Biblioteca.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biblioteca.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class BookPage : ContentPage
    {
        BorrowedBook sl;
        public BookPage(BorrowedBook slist)
        {
            InitializeComponent();
            sl = slist;
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var product = (Book)BindingContext;
            await App.Database.SaveBookAsync(product);
            listView.ItemsSource = await App.Database.GetBookAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var product = (Book)BindingContext;
            await App.Database.DeleteBookAsync(product);
            listView.ItemsSource = await App.Database.GetBookAsync();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetBookAsync();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            Book p;
            if (e.SelectedItem != null)
            {
                p = e.SelectedItem as Book;
                var lp = new ListBook()
                {
                    BorrowedBookID = sl.ID,
                    BookID = p.ID
                };
                await App.Database.SaveListBookAsync(lp);
                p.ListBooks = new List<ListBook> { lp };

                await Navigation.PopAsync();
            }
        }
    }
}