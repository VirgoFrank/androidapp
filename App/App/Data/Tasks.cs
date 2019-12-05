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

namespace App.Resources.Data
{
    public partial class Tasks
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<TaskDetails> Results { get; set; }
    }

    public partial class TaskDetails
    {
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}