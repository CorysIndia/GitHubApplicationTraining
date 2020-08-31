using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_STG 
{ 
    [ExportSynoptic("_04stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _04STG
    { 
        public _04STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
