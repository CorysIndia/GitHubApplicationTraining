using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_11stg_diag")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _11STG_DIAG
    { 
        public _11STG_DIAG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
