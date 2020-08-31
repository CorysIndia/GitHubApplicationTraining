using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("seq_3")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Seq_3
    { 
        public Seq_3() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
