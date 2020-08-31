using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag02")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag02
    { 
        public Diag02() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
