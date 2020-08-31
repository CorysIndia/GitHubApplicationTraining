using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_03cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _03CAT01
    { 
        public _03CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
