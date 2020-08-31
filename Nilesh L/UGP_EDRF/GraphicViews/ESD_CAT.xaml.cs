using System; 
using System.Windows; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF
{ 
    [ExportSynoptic("esd_cat")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class ESD_CAT
    { 
        public ESD_CAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
