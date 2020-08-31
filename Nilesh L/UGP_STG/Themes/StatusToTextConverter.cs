// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="StatusToTextConverter.cs" company="CORYS">
//    Copyright (c) CORYS - All Rights Reserved
//  </copyright>
//  <summary>
//  </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Windows;
using RSI.Common.Converters;
using RSI.Common.Converters.TypeConverter;
using RSI.Kernel.Model.Enums;

namespace UGP_STG.Themes
{
    public class StatusToTextConverter : ValueConverter<StatusToTextConverter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusToTextConverter"/> class.
        /// </summary>
        // ReSharper disable once EmptyConstructor
        public StatusToTextConverter()
        {

        }
        /// <summary>
        /// Converts the implementation.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="targetType">Type of the target.</param>
        /// <param name="parameter">The parameter.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        protected override object ConvertImpl(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return DependencyProperty.UnsetValue;
            }

            int index;
            if (!value.TryConvertTo(out index) || index < 0 || index >= ConstStatus.EnumItems.Length)
            {
                return DependencyProperty.UnsetValue;
            }
            var key = ConstStatus.EnumItems[index];

            string newValue = value.ToString();

            try
            {
                newValue = UGP_STG.Properties.Resources.ResourceManager.GetString(key);

            }
            catch
            {
            }

            return newValue;

        }
    }
}