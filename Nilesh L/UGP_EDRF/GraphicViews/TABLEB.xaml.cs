using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
namespace UGP_EDRF
{
    [ExportSynoptic("tableb")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TABLEB
    {
        public TABLEB()
        {
            this.InitializeComponent();
        }
    }
}
