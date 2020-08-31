using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_02cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _02CAT01
    { 
        public _02CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
