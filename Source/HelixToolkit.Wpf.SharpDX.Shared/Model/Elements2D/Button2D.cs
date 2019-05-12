﻿using System.Windows;
using System.Windows.Media;

#if COREWPF
namespace HelixToolkit.SharpDX.Core.Wpf
#else
namespace HelixToolkit.Wpf.SharpDX
#endif
{
    namespace Elements2D
    {
        public class Button2D : Clickable2D
        {
            static Button2D()
            {
                DefaultStyleKeyProperty.OverrideMetadata(
                    typeof(Button2D), new FrameworkPropertyMetadata(typeof(Button2D)));
            }
        }
    }

}