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

namespace Dispenza
{
    class ListaDispensaAdapter : BaseAdapter<string>
    {
        private List<string> itens = new List<string>();
        private Context context;

        public ListaDispensaAdapter(Context context, List<string> itens)
        {
            this.itens = itens;
            this.context = context;
        }

        public override string this[int position]
        {
            get {return itens[position];}
        }

        public override int Count
        {
            get{ return itens.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.ItemDispensa,null,false);
            }
            TextView nomeItem = row.FindViewById<TextView>(Resource.Id.NomeItem);
            nomeItem.Text = itens[position];
            return row;
        }
    }
}