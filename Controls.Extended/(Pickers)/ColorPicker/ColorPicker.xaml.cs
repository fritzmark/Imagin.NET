﻿using Imagin.Common.Extensions;
using Imagin.Common.Input;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Imagin.Controls.Extended
{
    /// <summary>
    /// A color picker inspired by http://www.codeproject.com/Articles/131708/WPF-Color-Picker-Construction-Kit.
    /// </summary>
    public partial class ColorPicker : UserControl, IBrushPicker<SolidColorBrush>
    {
        #region Properties

        public event EventHandler<EventArgs<Color>> SelectedColorChanged;

        public ColorSelector.SelectionRingType SelectionRing
        {
            get
            {
                return this.PART_ColorSelector.SelectionRing;
            }
            set
            {
                this.PART_ColorSelector.SelectionRing = value;
            }
        }

        #region Dependency

        double? LastComponentsWidth = null;

        public static DependencyProperty ComponentsWidthProperty = DependencyProperty.Register("ComponentsWidth", typeof(double), typeof(ColorPicker), new FrameworkPropertyMetadata(425.0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public double ComponentsWidth
        {
            get
            {
                return (double)GetValue(ComponentsWidthProperty);
            }
            set
            {
                SetValue(ComponentsWidthProperty, value);
            }
        }

        public static DependencyProperty InitialColorProperty = DependencyProperty.Register("InitialColor", typeof(Color), typeof(ColorPicker), new FrameworkPropertyMetadata(Colors.Transparent, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnInitialColorChanged));
        public Color InitialColor
        {
            get
            {
                return (Color)GetValue(InitialColorProperty);
            }
            set
            {
                SetValue(InitialColorProperty, value);
            }
        }
        static void OnInitialColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var cpf = (ColorPicker)d;
            cpf.newCurrent.CurrentColor = (Color)e.NewValue;
        }

        public static DependencyProperty ModelsProperty = DependencyProperty.Register("Models", typeof(ObservableCollection<ColorSpaceModel>), typeof(ColorPicker), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public ObservableCollection<ColorSpaceModel> Models
        {
            get
            {
                return (ObservableCollection<ColorSpaceModel>)GetValue(ModelsProperty);
            }
            private set
            {
                SetValue(ModelsProperty, value);
            }
        }

        public static DependencyProperty SelectedColorProperty = DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorPicker), new FrameworkPropertyMetadata(Colors.Transparent, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSelectedColorChanged));
        public Color SelectedColor
        {
            get
            {
                return (Color)GetValue(SelectedColorProperty);
            }
            set
            {
                SetValue(SelectedColorProperty, value);
            }
        }
        static void OnSelectedColorChanged(DependencyObject Object, DependencyPropertyChangedEventArgs e)
        {
            var ColorPicker = (ColorPicker)Object;
            ColorPicker.PART_ColorSelector.Color = (Color)e.NewValue;
            ColorPicker.OnSelectedColorChanged((Color)e.NewValue);
        }

        public static DependencyProperty ShowComponentsProperty = DependencyProperty.Register("ShowComponents", typeof(bool), typeof(ColorPicker), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnShowComponentsChanged));
        public bool ShowComponents
        {
            get
            {
                return (bool)GetValue(ShowComponentsProperty);
            }
            set
            {
                SetValue(ShowComponentsProperty, value);
            }
        }
        static void OnShowComponentsChanged(DependencyObject Object, DependencyPropertyChangedEventArgs e)
        {
            var This = Object.As<ColorPicker>();

            if (!e.NewValue.To<bool>())
            {
                This.LastComponentsWidth = This.ComponentsWidth;
                This.ComponentsWidth = 0d;
            }
            else if (This.ComponentsWidth == 0 && This.LastComponentsWidth != null)
            {
                This.ComponentsWidth = This.LastComponentsWidth.Value;
                This.LastComponentsWidth = null;
            }
        }
        
        public static DependencyProperty ShowNewCurrentProperty = DependencyProperty.Register("ShowNewCurrent", typeof(bool), typeof(ColorPicker), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public bool ShowNewCurrent
        {
            get
            {
                return (bool)GetValue(ShowNewCurrentProperty);
            }
            set
            {
                SetValue(ShowNewCurrentProperty, value);
            }
        }

        public static DependencyProperty ShowSliderProperty = DependencyProperty.Register("ShowSlider", typeof(bool), typeof(ColorPicker), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public bool ShowSlider
        {
            get
            {
                return (bool)GetValue(ShowSliderProperty);
            }
            set
            {
                SetValue(ShowSliderProperty, value);
            }
        }

        public static DependencyProperty ShowAlphaSliderProperty = DependencyProperty.Register("ShowAlphaSlider", typeof(bool), typeof(ColorPicker), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public bool ShowAlphaSlider
        {
            get
            {
                return (bool)GetValue(ShowAlphaSliderProperty);
            }
            set
            {
                SetValue(ShowAlphaSliderProperty, value);
            }
        }

        #endregion

        #endregion

        #region ColorPicker

        public ColorPicker()
        {
            InitializeComponent();

            Models = new ObservableCollection<ColorSpaceModel>();
            Models.Add(new RgbModel());
            Models.Add(new HsbModel());
            Models.Add(new HslModel());
            Models.Add(new XyzModel());
            Models.Add(new LabModel());
            Models.Add(new LchModel());
            //this.Models.Add(new LuvModel());
            //this.Models.Add(new CmykModel());

            PART_ColorSelector.ColorChanged += OnColorSelectorColorChanged;

            LayoutUpdated += (s, e) =>
            {
                if (!IsLoaded || PART_ColorSelector.NormalComponent != null) return;
                if (PART_ColorSelector.NormalComponent == null)
                    Models.Where(x => x.Is<HsbModel>()).First().Components[typeof(HsbModel.HComponent)].As<NormalComponentModel>().IsEnabled = true;
            };
        }

        #endregion

        #region Events

        void OnColorSelectorColorChanged(object sender, EventArgs<Color> e)
        {
            SetValue(SelectedColorProperty, e.Value);
            this.OnSelectedColorChanged(e.Value.As<Color>());
        }

        void OnComponentChecked(object sender, RoutedEventArgs e)
        {
            this.PART_ColorSelector.NormalComponent = sender.As<FrameworkElement>().Tag.As<NormalComponentModel>();
        }

        protected virtual void OnSelectedColorChanged(Color Color)
        {
            if (this.SelectedColorChanged != null)
                this.SelectedColorChanged(this, new EventArgs<Color>(Color));
        }

        #endregion
    }
}