using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;
using ManagedInterfaces;

namespace UGP_EDRF.HMI
{
    public class Type2_BaseplatePIDDisplay_III : RSIControlModel
    {
        static Type2_BaseplatePIDDisplay_III()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Type2_BaseplatePIDDisplay_III), new FrameworkPropertyMetadata(typeof(Type2_BaseplatePIDDisplay_III)));
        }

		public Type2_BaseplatePIDDisplay_III()
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
            DependencyProperty.Register("ControlMargin", typeof(Thickness), typeof(Type2_BaseplatePIDDisplay_III));

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
        /// Alarm Property
        /// </summary>
        public static readonly DependencyProperty AlarmProperty =
            DependencyProperty.Register("Alarm", typeof(bool), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the Alarm.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Put the alarm tagname here to enable alarm indicator. 
When True, indicator is hidden.
When False, indicator will appear.")]
        public bool Alarm
        {
            get { return (bool)this.GetValue(AlarmProperty); }
            set { this.SetValue(AlarmProperty, value); }
        }

        /// <summary>
        /// Value Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(Type2_BaseplatePIDDisplay_III));

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
        /// Disable Property
        /// </summary>
        public static readonly DependencyProperty DisableProperty =
            DependencyProperty.Register("Disable", typeof(String), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the Disable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"False=Enable value enterable ")]
        public String Disable
        {
            get { return (String)this.GetValue(DisableProperty); }
            set { this.SetValue(DisableProperty, value); }
        }

        /// <summary>
        /// Enterable Property
        /// </summary>
        public static readonly DependencyProperty EnterableProperty =
            DependencyProperty.Register("Enterable", typeof(double), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the Enterable.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public double Enterable
        {
            get { return (double)this.GetValue(EnterableProperty); }
            set { this.SetValue(EnterableProperty, value); }
        }

        /// <summary>
        /// EnterType Property
        /// </summary>
        public static readonly DependencyProperty EnterTypeProperty =
            DependencyProperty.Register("EnterType", typeof(bool), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the EnterType.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enterable type. 
FALSE==> analog box (default)
TRUE==> key pad")]
        public bool EnterType
        {
            get { return (bool)this.GetValue(EnterTypeProperty); }
            set { this.SetValue(EnterTypeProperty, value); }
        }

        /// <summary>
        /// Units Property
        /// </summary>
        public static readonly DependencyProperty UnitsProperty =
            DependencyProperty.Register("Units", typeof(string), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the Units.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname with the '.ENGUNITS' field to display the units of the Value tag. ")]
        public string Units
        {
            get { return (string)this.GetValue(UnitsProperty); }
            set { this.SetValue(UnitsProperty, value); }
        }

        /// <summary>
        /// TagDescrp Property
        /// </summary>
        public static readonly DependencyProperty TagDescrpProperty =
            DependencyProperty.Register("TagDescrp", typeof(string), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the TagDescrp.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname with the '.comment' field to display the units of the Value tag. ")]
        public string TagDescrp
        {
            get { return (string)this.GetValue(TagDescrpProperty); }
            set { this.SetValue(TagDescrpProperty, value); }
        }

        /// <summary>
        /// ZEnableDisableMD Property
        /// </summary>
        public static readonly DependencyProperty ZEnableDisableMDProperty =
            DependencyProperty.Register("ZEnableDisableMD", typeof(string), typeof(dIndTxt_02));

        /// <summary>
        /// Gets or sets the ZEnableDisableMD.  
        /// </summary>
		[Category("RSI")]
        [Description(@"")]
        public string ZEnableDisableMD
        {
            get { return (string)this.GetValue(ZEnableDisableMDProperty); }
            set { this.SetValue(ZEnableDisableMDProperty, value); }
        }





        /// <summary>
        /// TagName Property
        /// </summary>
        public new static readonly DependencyProperty TagNameProperty =
            DependencyProperty.Register("TagName", typeof(string), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the TagName.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Insert the tagname with the '.name' field to display the units of the Value tag. ")]
        public new string TagName
        {
            get { return (string)this.GetValue(TagNameProperty); }
            set { this.SetValue(TagNameProperty, value); }
        }

        /// <summary>
        /// DisableTag Property
        /// </summary>
        public static readonly DependencyProperty DisableTagProperty =
            DependencyProperty.Register("DisableTag", typeof(String), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the DisableTag.  
        /// </summary>
		[Category("RSI")]
        [Description(@"True = Disable Tag name and Tag Discription function                         False = enable Tag name and Tag Discription function")]
        public String DisableTag
        {
            get { return (String)this.GetValue(DisableTagProperty); }
            set { this.SetValue(DisableTagProperty, value); }
        }

        /// <summary>
        /// MIN Property
        /// </summary>
        public static readonly DependencyProperty MINProperty =
            DependencyProperty.Register("MIN", typeof(double), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the MIN.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double MIN
        {
            get { return (double)this.GetValue(MINProperty); }
            set { this.SetValue(MINProperty, value); }
        }

        /// <summary>
        /// MAX Property
        /// </summary>
        public static readonly DependencyProperty MAXProperty =
            DependencyProperty.Register("MAX", typeof(double), typeof(Type2_BaseplatePIDDisplay_III));

        /// <summary>
        /// Gets or sets the MAX.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Enter the tagname + '.MaxEU'")]
        public double MAX
        {
            get { return (double)this.GetValue(MAXProperty); }
            set { this.SetValue(MAXProperty, value); }
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

				if (!string.IsNullOrWhiteSpace(this.Units)) yield return new Param("$Units", this.Units);
if (!string.IsNullOrWhiteSpace(this.TagDescrp)) yield return new Param("$TagDescrp", this.TagDescrp);
if (!string.IsNullOrWhiteSpace(this.TagName)) yield return new Param("$TagName", this.TagName);
if (!string.IsNullOrWhiteSpace(this.ModelName)) yield return new Param("$ModelName", this.ModelName);
if (!string.IsNullOrWhiteSpace(this.ZEnableDisableMD)) yield return new Param("$ZEnableDisableMD", this.ZEnableDisableMD);
if (!string.IsNullOrWhiteSpace(this.Disable)) yield return new Param("$Disable", this.Disable);

            }
        }

		
    }
}
