using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_05OVIEW01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _05OVIEW01
    { 
        public _05OVIEW01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
