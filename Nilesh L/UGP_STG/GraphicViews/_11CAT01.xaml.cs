using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_11cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _11CAT01
    { 
        public _11CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
