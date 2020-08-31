using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_06stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _06STG
    { 
        public _06STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
