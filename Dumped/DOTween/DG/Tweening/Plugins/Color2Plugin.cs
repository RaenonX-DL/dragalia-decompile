/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins
{
	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions>
	{
		// Constructors
		public Color2Plugin();
	
		// Methods
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t);
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative);
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value);
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t);
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t);
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue);
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
