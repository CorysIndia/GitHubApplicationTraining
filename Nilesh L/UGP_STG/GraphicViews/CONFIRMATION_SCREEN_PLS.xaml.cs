using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("confirmation_screen_pls")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class CONFIRMATION_SCREEN_PLS
    { 
        public CONFIRMATION_SCREEN_PLS() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
