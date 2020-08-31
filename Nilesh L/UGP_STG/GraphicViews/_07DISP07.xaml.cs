using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_07disp07")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _07DISP07
    { 
        public _07DISP07() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
