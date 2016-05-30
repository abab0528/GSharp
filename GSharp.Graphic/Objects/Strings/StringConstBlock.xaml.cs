﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GSharp.Graphic.Blocks;
using GSharp.Graphic.Holes;
using GSharp.Base.Cores;
using GSharp.Base.Objects;
using GSharp.Base.Objects.Strings;

namespace GSharp.Graphic.Objects.Strings
{
    /// <summary>
    /// NumberBlock.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StringConstBlock : StringBlock
    {
        public string String
        {
            get
            {
                return StringText.Text;
            }
            set
            {
                StringText.Text = value;
                _GStringConst.String = value;
            }
        }

        public override GString GString
        {
            get
            {
                return _GStringConst;
            }
        }
        
        public GStringConst GStringConst
        {
            get
            {
                return _GStringConst;
            }
        }
        private GStringConst _GStringConst;

        public override GObject GObject
        {
            get
            {
                return GString;
            }
        }

        public override List<GBase> ToGObjectList()
        {
            return new List<GBase> { GObject };
        }

        public StringConstBlock()
        {
            _GStringConst = new GStringConst("");

            InitializeComponent();
            InitializeBlock();
        }

        private void StringText_TextChanged(object sender, TextChangedEventArgs e)
        {
            _GStringConst.String = StringText.Text;
        }
    }
}