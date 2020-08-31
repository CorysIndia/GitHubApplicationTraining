using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_STG 
{ 
    [ExportSynoptic("_05stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _05STG
    { 
        public _05STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
