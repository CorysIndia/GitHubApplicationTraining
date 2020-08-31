using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("hmi_comm_fail")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class HMI_COMM_FAIL
    { 
        public HMI_COMM_FAIL() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
