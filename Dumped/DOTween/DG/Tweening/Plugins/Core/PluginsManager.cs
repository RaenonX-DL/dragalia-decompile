/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Plugins.Options;

// Image 40: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins.Core
{
	internal static class PluginsManager
	{
		// Fields
		private static ITweenPlugin _floatPlugin;
		private static ITweenPlugin _doublePlugin;
		private static ITweenPlugin _intPlugin;
		private static ITweenPlugin _uintPlugin;
		private static ITweenPlugin _longPlugin;
		private static ITweenPlugin _ulongPlugin;
		private static ITweenPlugin _vector2Plugin;
		private static ITweenPlugin _vector3Plugin;
		private static ITweenPlugin _vector4Plugin;
		private static ITweenPlugin _quaternionPlugin;
		private static ITweenPlugin _colorPlugin;
		private static ITweenPlugin _rectPlugin;
		private static ITweenPlugin _rectOffsetPlugin;
		private static ITweenPlugin _stringPlugin;
		private static ITweenPlugin _vector3ArrayPlugin;
		private static ITweenPlugin _color2Plugin;
		private const int _MaxCustomPlugins = 20;
		private static Dictionary<Type, ITweenPlugin> _customPlugins;
	
		// Methods
		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions;
		public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>()
			where TPlugin : ITweenPlugin, new()
			where TPlugOptions : struct, IPlugOptions;
		internal static void PurgeAll();
	}
}
