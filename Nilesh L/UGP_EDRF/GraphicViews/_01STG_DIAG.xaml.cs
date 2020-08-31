using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_01stg_diag")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _01STG_DIAG
    { 
        public _01STG_DIAG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
