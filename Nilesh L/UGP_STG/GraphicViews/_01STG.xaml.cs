using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_STG 
{ 
    [ExportSynoptic("_01stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _01STG
    { 
        public _01STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
