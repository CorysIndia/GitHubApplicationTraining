using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_STG 
{ 
    [ExportSynoptic("_09stg")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _09STG
    { 
        public _09STG() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
