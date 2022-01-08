using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biblioteca.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (BorrowedBook)BindingContext;
            slist.BorrowedDate = DateTime.UtcNow;
            await App.Database.SaveBorrowedBookAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (BorrowedBook)BindingContext;
            await App.Database.DeleteBorrowedBookAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnChooseButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookPage((BorrowedBook)
           this.BindingContext)
            {
                BindingContext = new Book()
            });

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var shopl = (BorrowedBook)BindingContext;

            listView.ItemsSource = await App.Database.GetListBooksAsync(shopl.ID);
        }

    }
}