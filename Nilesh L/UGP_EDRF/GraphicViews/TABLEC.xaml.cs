using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
namespace UGP_EDRF
{
    [ExportSynoptic("tablec")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TABLEC
    {
        public TABLEC()
        {
            this.InitializeComponent();
        }
    }
}
