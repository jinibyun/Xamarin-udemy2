using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_Sqlite : ContentPage
	{
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _receipes;
        public Data_Sqlite ()
		{
			InitializeComponent ();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected async override void OnAppearing()
        {
            // create table
            await _connection.CreateTableAsync<Recipe>();

            // get
            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _receipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _receipes;

            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe " + DateTime.Now.Ticks };
            await _connection.InsertAsync(recipe);
            _receipes.Add(recipe);
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var recipe = _receipes[0];
            recipe.Name += " Updated";

            await _connection.UpdateAsync(recipe);

        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var recipe = _receipes[0];
            await _connection.DeleteAsync(recipe);
            _receipes.Remove(recipe);
        }
    }

    public class Recipe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value)
                    return;
                _name = value;
                OnPorpertyChanged();
            }
        }
        private void OnPorpertyChanged([CallerMemberName] string propertyName = null)
        {
            //if (PropertyChanged != null)
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}