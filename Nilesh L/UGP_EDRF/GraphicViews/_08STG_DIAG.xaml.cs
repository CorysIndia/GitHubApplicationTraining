using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_08stg_diag")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _08STG_DIAG
    { 
        public _08STG_DIAG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
