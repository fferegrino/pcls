using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PclCalculadora.Droid
{
    [Activity(Label = "PclCalculadora.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText editText1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText editText2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView textView3 = FindViewById<TextView>(Resource.Id.textView3);

            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
            {
                var calculadora = new Calculadora(); Console.WriteLine("Primer número:");
                calculadora.SetPrimerNumero(Int32.Parse(editText1.Text));
                Console.WriteLine("Segundo número:");
                calculadora.SetSegundoNumero(Int32.Parse(editText2.Text));

                textView3.Text = calculadora.Calcula().ToString();
            };
        }
    }
}

