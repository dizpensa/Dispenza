using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Dispenza
{
    [Activity(Label = "Dispenza", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<string> itens = new List<string>();
        private ListView listaDispensa;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.Hide();
            SetContentView(Resource.Layout.Main);

            listaDispensa = FindViewById<ListView>(Resource.Id.ListaDispensa);
            itens.Add("Arroz");
            itens.Add("Feijão");
            itens.Add("Carne");
            ListaDispensaAdapter adapter = new ListaDispensaAdapter(this, itens);
            listaDispensa.Adapter = adapter;
            /*
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            */
        }
    }
}

