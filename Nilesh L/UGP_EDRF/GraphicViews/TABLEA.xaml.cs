using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
namespace UGP_EDRF
{
    [ExportSynoptic("tablea")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TABLEA
    {
        public TABLEA()
        {
            this.InitializeComponent();
        }
    }
}
