using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Media;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Brush = System.Drawing.Brush;
using Color = System.Drawing.Color;

namespace TestBinar.Model
{
    public class Diskret : ViewModelBase
    {




        private string _name;
        private string _groupHeader;
        private SolidColorBrush _colorTile = new SolidColorBrush(Colors.Blue);
        private bool _isFlowBreak;

        public bool IsFlowBreak
        {
            get => _isFlowBreak;
            set => SetValue(ref _isFlowBreak, value);
        }
        public string Name
        {
            get => _name;
            set => SetValue(ref _name, value);
        }

        public string GroupHeader
        {
            get => _groupHeader;
            set => SetValue(ref _groupHeader, value);
        }

        public SolidColorBrush ColorTile
        {
            get => _colorTile;
            set => SetValue(ref _colorTile, value);
        }

        private bool _iSActive;

        public bool iSActive
        {
            get => _iSActive;
            set => SetValue(ref _iSActive, value);
        }

    }
}

