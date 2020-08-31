using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_10stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _10STG
    { 
        public _10STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
