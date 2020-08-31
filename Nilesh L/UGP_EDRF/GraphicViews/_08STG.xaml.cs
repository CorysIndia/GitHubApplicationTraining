using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_08stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _08STG
    { 
        public _08STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
