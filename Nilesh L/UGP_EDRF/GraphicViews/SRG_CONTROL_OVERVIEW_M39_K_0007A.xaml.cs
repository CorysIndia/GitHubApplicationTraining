
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
    [ExportSynoptic("srg_control_overview_m39_k_0007a")] 
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SRG_CONTROL_OVERVIEW_M39_K_0007A
    {
        public SRG_CONTROL_OVERVIEW_M39_K_0007A()
        {
            if (Designer.IsInDesignModeStatic == false)
            {
                ServiceLocator.Instance.RegisterType<ID3Factory, OxyPlotFactory>();
                this.OnceLoaded(fe => ServiceLocator.Instance.UnregisterType<ID3Factory>());
            }
            this.Loaded += SRG_CONTROL_OVERVIEW_M39_K_0007A_Loaded;
            this.InitializeComponent();
        }

        private void SRG_CONTROL_OVERVIEW_M39_K_0007A_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SurgeReferencePlot7A1.ShowAxis = false;
            ControlReferencePlot7A1.ShowAxis = false;
            HoverPoint7A1.ShowAxis = false;
            OperatingPoint7A1.ShowAxis = false;
            SurgeLinePlot7A1.ShowAxis = false;
            ControlLinePlot7A1.ShowAxis = false;

            SurgeReferencePlot7A2.ShowAxis = false;
            ControlReferencePlot7A2.ShowAxis = false;
            HoverPoint7A2.ShowAxis = false;
            OperatingPoint7A2.ShowAxis = false;
            SurgeLinePlot7A2.ShowAxis = false;
            ControlLinePlot7A2.ShowAxis = false;



        }
    }
} 
