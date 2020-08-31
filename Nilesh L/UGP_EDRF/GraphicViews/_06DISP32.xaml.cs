using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_06disp32")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _06DISP32
    { 
        public _06DISP32() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
