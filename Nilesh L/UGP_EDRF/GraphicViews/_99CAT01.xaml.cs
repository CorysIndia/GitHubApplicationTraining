using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_99cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _99CAT01
    { 
        public _99CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
