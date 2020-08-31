using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
using RSI.Common.Locator;
using RSI.IndissLike.Controls.Helpers;
using RSI.IndissPlus.Plots.Components;
using RSI.Common.WPFTools.Extensions;
using RSI.IndissPlus.Plots.OxyPlotTools;
using PlotComponent.Interfaces;
namespace UGP_EDRF 
{ 
    [ExportSynoptic("loadshare_k0007abcd")] 
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class LOADSHARE_K0007ABCD
    {
        public LOADSHARE_K0007ABCD()
        {
            if (Designer.IsInDesignModeStatic == false)
            {
                ServiceLocator.Instance.RegisterType<ID3Factory, OxyPlotFactory>();
                this.OnceLoaded(fe => ServiceLocator.Instance.UnregisterType<ID3Factory>());
            }
            this.Loaded += LOADSHARE_K0007ABCD_Loaded;
            this.InitializeComponent();
        }

        private void LOADSHARE_K0007ABCD_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SurgeReferencePlot.ShowAxis = false;
            ControlReferencePlot.ShowAxis = false;
            HoverPoint.ShowAxis = false;
            OperatingPoint.ShowAxis = false;
            SurgeLinePlot.ShowAxis = false;
            ControlLinePlot.ShowAxis = false;


            SurgeReferencePlotB.ShowAxis = false;
            ControlReferencePlotB.ShowAxis = false;
            HoverPointB.ShowAxis = false;
            OperatingPointB.ShowAxis = false;
            SurgeLinePlotB.ShowAxis = false;
            ControlLinePlotB.ShowAxis = false;

            SurgeReferencePlotC.ShowAxis = false;
            ControlReferencePlotC.ShowAxis = false;
            HoverPointC.ShowAxis = false;
            OperatingPointC.ShowAxis = false;
            SurgeLinePlotC.ShowAxis = false;
            ControlLinePlotC.ShowAxis = false;


            SurgeReferencePlotD.ShowAxis = false;
            ControlReferencePlotD.ShowAxis = false;
            HoverPointD.ShowAxis = false;
            OperatingPointD.ShowAxis = false;
            SurgeLinePlotD.ShowAxis = false;
            ControlLinePlotD.ShowAxis = false;



        }

    }
} 
