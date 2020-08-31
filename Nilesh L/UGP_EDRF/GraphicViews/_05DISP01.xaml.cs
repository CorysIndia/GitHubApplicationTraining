using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_05disp01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _05DISP01
    { 
        public _05DISP01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
