using System; 
using System.Windows; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("seq_1_fat")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Seq_1_FAT
    { 
        public Seq_1_FAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
