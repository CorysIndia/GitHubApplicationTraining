using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_05disp05")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _05DISP05
    { 
        public _05DISP05() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
