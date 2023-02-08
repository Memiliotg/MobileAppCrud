namespace PruebaOrionTek.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            //Get All Persons  
            var EmpresaList = await App.SQLiteDb.GetEmpresaAsync();
            if (EmpresaList != null)
            {
                EmpresaListView.ItemsSource = EmpresaList;
            }
        }

    }
}
