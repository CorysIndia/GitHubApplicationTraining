using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("heating")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class HEATING
    { 
        public HEATING() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
