using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("quit")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class QUIT
    { 
        public QUIT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
