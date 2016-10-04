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
    class ItemDispensa
    {
        private int quantidade;
        private string nome;
        public ItemDispensa(int quantidade, string nome)
        {
            this.nome = nome;
            this.quantidade = quantidade;
        }
        public int remove(int qnt)
        {
            if(quantidade - qnt <= 0)
            {
                quantidade = 0;
                return 1;
            }
            return 0;
        }
        public void adiciona(int qnt)
        {
            quantidade += qnt;
        }
    }
}