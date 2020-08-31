using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("seq_2")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Seq_2
    { 
        public Seq_2() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
