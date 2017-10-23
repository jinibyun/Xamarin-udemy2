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
	public partial class Form_Picker : ContentPage
	{
        private IList<ContactMethod> _contactMethods;

        public Form_Picker ()
		{
			InitializeComponent ();

            _contactMethods = GetContactMethod();
            foreach (var memeber in _contactMethods)
            {
                ContactMethod.Items.Add(memeber.Name);
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = ContactMethod.Items[ContactMethod.SelectedIndex];
            var contactMethod = _contactMethods.Single(x => x.Name == name);

            DisplayAlert("Selection", name, "OK");
        }

        private IList<ContactMethod> GetContactMethod()
        {
            return new List<ContactMethod>
            {
                new ContactMethod {Id = 1, Name="SMS" },
                new ContactMethod {Id = 2, Name="Email" }
            };
        }

        
    }

    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }


    }
}