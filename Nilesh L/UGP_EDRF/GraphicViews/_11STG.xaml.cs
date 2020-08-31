using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_11stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _11STG
    { 
        public _11STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
