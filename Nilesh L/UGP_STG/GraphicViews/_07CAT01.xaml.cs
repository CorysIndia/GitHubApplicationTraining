using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_07cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _07CAT01
    { 
        public _07CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
