using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("k0001_permissives")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class K0001_PERMISSIVES
    { 
        public K0001_PERMISSIVES() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
