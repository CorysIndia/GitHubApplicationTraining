using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;

namespace UGP_STG.HMI
{
    public class aIndDesLab_01_L : RSIControlModel
    {
        static aIndDesLab_01_L()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(aIndDesLab_01_L), new FrameworkPropertyMetadata(typeof(aIndDesLab_01_L)));
        }

		public aIndDesLab_01_L()
        {
            this.Loaded += OnLoaded; 
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            this.ControlMargin = ControlsHelper.GetControlMargin(this);
            this.Loaded -= OnLoaded;
        }

		      /// <summary>
        /// ControlMargin Property
        /// </summary>
        public static readonly DependencyProperty ControlMarginProperty =
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the Margin.  
        /// </summary>
        [Category("RSI")]
        [Description(@"")]
        public Thickness ControlMargin
        {
            get { return (Thickness)this.GetValue(ControlMarginProperty); }
            set { this.SetValue(ControlMarginProperty, value); }
        }


		        /// <summary>
        /// Value Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the Value.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Value
        {
            get { return (double)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Selected Property
        /// </summary>
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(bool), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the Selected.  
        /// </summary>
		[Category("RSI")]
        [Description(@"On true, description turns green")]
        public bool Selected
        {
            get { return (bool)this.GetValue(SelectedProperty); }
            set { this.SetValue(SelectedProperty, value); }
        }

        /// <summary>
        /// TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty TagDescrpProperty =
            DependencyProperty.Register("TagDescrp", typeof(string), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.comment' to display the tag description at the bottom bar")]
        public string TagDescrp
        {
            get { return (string)this.GetValue(TagDescrpProperty); }
            set { this.SetValue(TagDescrpProperty, value); }
        }

        /// <summary>
        /// TagName Property
        /// </summary>
        public new static readonly DependencyProperty TagNameProperty =
            DependencyProperty.Register("TagName", typeof(string), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.name' to display the tag description at the bottom bar")]
        public new string TagName
        {
            get { return (string)this.GetValue(TagNameProperty); }
            set { this.SetValue(TagNameProperty, value); }
        }

        /// <summary>
        /// Units Property
        /// </summary>
        public static readonly DependencyProperty UnitsProperty =
            DependencyProperty.Register("Units", typeof(string), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the Units.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname with '.engunits' to display the tag description at the bottom bar")]
        public string Units
        {
            get { return (string)this.GetValue(UnitsProperty); }
            set { this.SetValue(UnitsProperty, value); }
        }

        /// <summary>
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(bool), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the disable tag here
For example: fTBNSTART_DISHMI

True: disable button
False: enable button")]
        public bool Disable
        {
            get { return (bool)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// Alarm Property
        /// </summary>
        public static readonly DependencyProperty AlarmProperty =
            DependencyProperty.Register("Alarm", typeof(bool), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"TURN VALUE COLOUR INTO ORANGE, IF VALUE IS FALSE")]
        public bool Alarm
        {
            get { return (bool)this.GetValue(AlarmProperty); }
            set { this.SetValue(AlarmProperty, value); }
        }

        /// <summary>
        /// Fail Property
        /// </summary>
        public static readonly DependencyProperty FailProperty =
            DependencyProperty.Register("Fail", typeof(bool), typeof(aIndDesLab_01_L));

        /// <summary>
        /// Gets or sets the Fail.  
        /// </summary>
		[Category("RSI")]
        [Description(@"TURN VALUE COLOUR INTO RED, IF VALUE IS FALSE")]
        public bool Fail
        {
            get { return (bool)this.GetValue(FailProperty); }
            set { this.SetValue(FailProperty, value); }
        }


		
        public override bool HasIndissLikeParameters => true;

        public override IEnumerable<Param> IndissLikeParameters
        {
            get
            {
				foreach (var p in base.IndissLikeParameters)
				{
					yield return p;
				}

				if (!string.IsNullOrWhiteSpace(this.TagDescrp)) yield return new Param("$TagDescrp", this.TagDescrp);
if (!string.IsNullOrWhiteSpace(this.TagName)) yield return new Param("$TagName", this.TagName);
if (!string.IsNullOrWhiteSpace(this.Units)) yield return new Param("$Units", this.Units);

            }
        }

		
    }
}
