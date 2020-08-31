using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_05cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _05CAT01
    { 
        public _05CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
