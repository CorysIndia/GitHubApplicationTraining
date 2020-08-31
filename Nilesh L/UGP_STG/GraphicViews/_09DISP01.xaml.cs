using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_09disp01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _09DISP01
    { 
        public _09DISP01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
