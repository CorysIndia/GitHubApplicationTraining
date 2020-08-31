using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("blow_off")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class BLOW_OFF
    { 
        public BLOW_OFF() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
