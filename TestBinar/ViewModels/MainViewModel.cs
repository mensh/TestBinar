using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.LayoutControl;
using TestBinar.Model;

namespace TestBinar.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        ObservableCollection<Diskret> _diskretCollection = new ObservableCollection<Diskret>();
        private Orientation _orientation = Orientation.Vertical;

        public Orientation Orientation
        {
            get => _orientation;
            set => SetValue(ref _orientation, value);
        }


        [Command]
        public void DiskretClick(object e)
        {
            DXMessageBox.Show(((Tile)e).Content.ToString());
        }

        private bool state;
        [Command]
        public void DiskretDoubleClick(object e)
        {
            if (state)
            {
                Orientation = Orientation.Horizontal;
                state = !state;
            }
            else
            {
                Orientation = Orientation.Vertical;
                state = !state;
            }
        }
        public ObservableCollection<Diskret> DiskretCollection
        {
            get => _diskretCollection;
            set => SetValue(ref _diskretCollection, value);
        }

        public MainViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                Diskret d = new Diskret() { Name = "testDiskret " + i };
                if (i % 2 == 0)
                {
                    d.iSActive = true;
                    d.GroupHeader = "False";
                   // d.IsFlowBreak = false;
                }
                else
                {
                    d.GroupHeader = "True";
                   // d.IsFlowBreak = true;
                }
                DiskretCollection.Add(d);
            }
        }
    }
}