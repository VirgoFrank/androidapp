using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App
{
    [Activity(Label = "AddActivity")]
    public class AddActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.add_layout);

            var titleField = FindViewById<EditText>(Resource.Id.titleText);
            var descField = FindViewById<EditText>(Resource.Id.descText);
            var saveButton = FindViewById<Button>(Resource.Id.saveButton);

            saveButton.Click += async delegate
            {
                var title = titleField.Text;
                var desc = descField.Text;
                
            };
        }
    }
}