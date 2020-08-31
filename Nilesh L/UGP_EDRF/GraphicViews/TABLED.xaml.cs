using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
namespace UGP_EDRF
{
    [ExportSynoptic("tabled")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TABLED
    {
        public TABLED()
        {
            this.InitializeComponent();
        }
    }
}
