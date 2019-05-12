﻿#if NETFX_CORE
using Windows.UI.Xaml;
namespace HelixToolkit.UWP
#else
using System.ComponentModel;
using System.Windows;
#if COREWPF
using HelixToolkit.SharpDX.Core.Model;
namespace HelixToolkit.SharpDX.Core.Wpf
#else
namespace HelixToolkit.Wpf.SharpDX
#endif
#endif
{
    using Model;
    /// <summary>
    /// Render color by mesh vertex position
    /// </summary>
    public sealed class PositionColorMaterial : Material
    {
        protected override MaterialCore OnCreateCore()
        {
            return PositionMaterialCore.Core;
        }

        public PositionColorMaterial() { }

        public PositionColorMaterial(PositionMaterialCore core) : base(core) { }
#if !NETFX_CORE
        protected override Freezable CreateInstanceCore()
        {
            return new PositionColorMaterial()
            {
                Name = Name
            };
        }
#endif
    }
}