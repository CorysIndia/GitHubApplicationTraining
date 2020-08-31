using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_10cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _10CAT01
    { 
        public _10CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
