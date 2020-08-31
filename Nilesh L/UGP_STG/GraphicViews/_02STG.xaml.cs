using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_STG 
{ 
    [ExportSynoptic("_02stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _02STG
    { 
        public _02STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
