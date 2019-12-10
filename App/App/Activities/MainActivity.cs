using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var searchEditText = FindViewById<EditText>(Resource.Id.searchEditText);
            var searchButton = FindViewById<Button>(Resource.Id.searchButton);
            var searchListView = FindViewById<ListView>(Resource.Id.searchListView);
            var toAddActivityButton = FindViewById<Button>(Resource.Id.addButton);

            toAddActivityButton.Click += toAddActivityButton_Click;
            ReadAsync();
        }

        public async Task ReadAsync()
        {
            var searchListView = FindViewById<ListView>(Resource.Id.searchListView);
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            foreach (var file in Directory.GetFiles(path))
            {
                File.Exists(file);
            }
            return;
        }

        private void toAddActivityButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(AddActivity));
            StartActivity(intent);
        }
    }
}