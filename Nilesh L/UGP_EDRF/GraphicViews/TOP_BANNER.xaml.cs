using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("top_banner")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class TOP_BANNER
    { 
        public TOP_BANNER() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
