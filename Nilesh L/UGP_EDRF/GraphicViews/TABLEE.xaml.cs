using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
namespace UGP_EDRF
{
    [ExportSynoptic("tablee")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TABLEE
    {
        public TABLEE()
        {
            this.InitializeComponent();
        }
    }
}
