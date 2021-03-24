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
using UnityEngine;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins
{
	public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions>
	{
		// Constructors
		public ColorPlugin();
	
		// Methods
		public override void Reset(TweenerCore<Color, Color, ColorOptions> t);
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative);
		public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value);
		public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t);
		public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t);
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue);
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
