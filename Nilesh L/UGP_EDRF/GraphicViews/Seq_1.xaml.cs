using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("seq_1")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Seq_1
    { 
        public Seq_1() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
