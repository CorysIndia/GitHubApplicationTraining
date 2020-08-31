using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_03stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _03STG
    { 
        public _03STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
