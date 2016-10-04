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
        private List<ItemDispensa> itensD = new List<ItemDispensa>();
        private ListView listaDispensa;
        private Button adicionar;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //ActionBar.Hide();
            SetContentView(Resource.Layout.Main);

            adicionar = FindViewById<Button>(Resource.Id.AdicionarItemDispensa);

            itensD.Add(new ItemDispensa(1, "Arroz"));
            itensD.Add(new ItemDispensa(2, "Banana"));
            itensD.Add(new ItemDispensa(3, "Carambola"));

            listaDispensa = FindViewById<ListView>(Resource.Id.ListaDispensa);
            itens.Add("Arroz");
            itens.Add("Feijão");
            itens.Add("Carne");
            ListaDispensaAdapter adapter = new ListaDispensaAdapter(this, itens);
            listaDispensa.Adapter = adapter;
            listaDispensa.ItemClick += ListaDispensa_ItemClick;
            adicionar.Click += Adicionar_Click;
        }

        private void ListaDispensa_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            itens.RemoveAt(e.Position);
            ListaDispensaAdapter adapter = new ListaDispensaAdapter(this, itens);
            listaDispensa.Adapter = adapter;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            itens.Add("Item padão");
            ListaDispensaAdapter adapter = new ListaDispensaAdapter(this, itens);
            listaDispensa.Adapter = adapter;
        }
    }
}

