﻿using Imagin.Common.Extensions;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Imagin.Controls.Common
{
    public class LongUpDown : NumericUpDown
    {
        public override Regex Expression
        {
            get
            {
                return new Regex("^[0-9]?$");
            }
        }

        public long Value
        {
            get
            {
                if (string.IsNullOrEmpty(this.Text))
                    return 0L;
                else return this.Text.ToLong();
            }
        }

        public static DependencyProperty IncrementProperty = DependencyProperty.Register("Increment", typeof(long), typeof(LongUpDown), new FrameworkPropertyMetadata(1L, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public long Increment
        {
            get
            {
                return (long)GetValue(IncrementProperty);
            }
            set
            {
                SetValue(IncrementProperty, value);
            }
        }

        public static DependencyProperty MinimumProperty = DependencyProperty.Register("Minimum", typeof(long), typeof(LongUpDown), new FrameworkPropertyMetadata(0L, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public long Minimum
        {
            get
            {
                return (long)GetValue(MinimumProperty);
            }
            set
            {
                SetValue(MinimumProperty, value);
            }
        }

        public static DependencyProperty MaximumProperty = DependencyProperty.Register("Maximum", typeof(long), typeof(LongUpDown), new FrameworkPropertyMetadata(1000000L, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public long Maximum
        {
            get
            {
                return (long)GetValue(MaximumProperty);
            }
            set
            {
                SetValue(MaximumProperty, value);
            }
        }

        public LongUpDown() : base()
        {
        }

        public override object GetValue()
        {
            return this.Value;
        }

        protected override void CoerceValue(object NewValue)
        {
            if (NewValue.As<long>() < this.Minimum)
                this.SetText(this.Minimum, true);
            if (NewValue.As<long>() > this.Maximum)
                this.SetText(this.Maximum, true);
        }

        protected override void FormatValue(string StringFormat)
        {
            if (!string.IsNullOrEmpty(StringFormat))
                this.SetText(this.Value.ToString(StringFormat), true);
        }

        protected override void Up_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.SetText(this.Value + this.Increment);
        }
        protected override void Up_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.Value < this.Maximum;
        }

        protected override void Down_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Text = (this.Value - this.Increment).ToString();
        }
        protected override void Down_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.Value > this.Minimum;
        }
    }
}