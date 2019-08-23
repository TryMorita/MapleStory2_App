using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System.Json;
namespace OneMinParseMS2
{
    [Activity(Label = "OneMinParseMS2", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView TxtNumber;

        int number;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.content_main);

            TxtNumber = FindViewById<TextView>(Resource.Id.txtNumber);

            FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) =>
            TxtNumber.Text = (++number).ToString();

            FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) =>
            TxtNumber.Text = (--number).ToString();



            var spin = FindViewById<Spinner>(Resource.Id.spinner1);

            spin.ItemSelected += (s, e) =>
            {
                Toast.MakeText(this, "You Selected" + e.Parent.GetItemAtPosition(e.Position).ToString(), ToastLength.Short).Show();
            };
    

        }

    }
}