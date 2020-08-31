using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_90cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _90CAT01
    { 
        public _90CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
