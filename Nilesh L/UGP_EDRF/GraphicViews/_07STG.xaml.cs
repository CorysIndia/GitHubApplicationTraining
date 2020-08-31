using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_07stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _07STG
    { 
        public _07STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
