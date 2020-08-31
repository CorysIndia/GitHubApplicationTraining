using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("security_names")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SECURITY_NAMES
    { 
        public SECURITY_NAMES() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
