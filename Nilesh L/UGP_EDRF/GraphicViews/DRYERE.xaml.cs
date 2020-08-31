using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("dryere")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DRYERE
    { 
        public DRYERE() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
