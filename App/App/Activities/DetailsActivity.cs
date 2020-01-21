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
using App.Models;

namespace App.Activities
{
    [Activity(Label = "DetailsActivity")]
    public class DetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.details);

            var title = FindViewById<EditText>(Resource.Id.titleText);
            var desc = FindViewById<EditText>(Resource.Id.descText);

            //var details = Note;
            //title.Text = details.title;
            //desc.Text = details.desc;

            //update function

            //delete function
        }
    }
}