using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag13")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag13
    { 
        public Diag13() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
