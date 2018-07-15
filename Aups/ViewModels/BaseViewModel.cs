using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Aups.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {

        protected void BindItemsToListView(ListView listView, string collectionProperty = "Items", string propertyName = "Item")
        {
            var itemSourceBinding = new Binding
            {
                Source = this,
                Mode = BindingMode.TwoWay,
                Path = new PropertyPath(collectionProperty),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(listView, ItemsControl.ItemsSourceProperty, itemSourceBinding);
            var selectedItemBinding = new Binding
            {
                Source = this,
                Mode = BindingMode.TwoWay,
                Path = new PropertyPath(propertyName),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(listView, Selector.SelectedItemProperty, selectedItemBinding);
        }
       
        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
