using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Data_RestfulWebService : ContentPage
	{
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        /*
        For having seamless https support on Android and iOS you can use modernhttpclient, follow these steps:
        - Open NuGet Manager
        - search for ModernHttpClient by Paul Betts
        - add that package to all projects (PCL, Android, iOS)
        - In VS click on Build and select "Clean Solution"
        - Pass in to HttpClient a NativeMessageHander object like this:

        private HttpClient _client = new HttpClient(new NativeMessageHandler()); 
        */

        // note: to use HttpClient, nuget package: Microsoft.Net.Http (rather than anything else)
        // ref: http://blog.xhackers.co/httpclient-with-xamarin-forms/
        private HttpClient _client = new HttpClient(new NativeMessageHandler());
        private ObservableCollection<Post> _posts;
        public Data_RestfulWebService ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);

            _posts = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _posts;
            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post { Title = "Title " + DateTime.Now.Ticks };

            _posts.Insert(0, post);

            var content = JsonConvert.SerializeObject(post);
            await _client.PostAsync(Url, new StringContent(content));
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            post.Title += " UPDATED";

            var content = JsonConvert.SerializeObject(post);
            await _client.PutAsync(Url + "/" + post.Id, new StringContent(content));
        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            _posts.Remove(post);
            await _client.DeleteAsync(Url + "/" + post.Id);
        }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}