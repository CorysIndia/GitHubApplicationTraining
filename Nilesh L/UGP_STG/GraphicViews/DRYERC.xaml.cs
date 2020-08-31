using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("dryerc")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DRYERC
    { 
        public DRYERC() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
