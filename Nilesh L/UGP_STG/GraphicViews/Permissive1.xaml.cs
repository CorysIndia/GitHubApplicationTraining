using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("permissive1")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Permissive1
    { 
        public Permissive1() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
