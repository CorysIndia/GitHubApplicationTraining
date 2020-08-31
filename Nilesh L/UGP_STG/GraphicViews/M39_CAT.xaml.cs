using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("m39_cat")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class M39_CAT
    { 
        public M39_CAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
