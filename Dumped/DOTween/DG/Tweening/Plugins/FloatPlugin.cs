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
	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions>
	{
		// Constructors
		public FloatPlugin();
	
		// Methods
		public override void Reset(TweenerCore<float, float, FloatOptions> t);
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative);
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value);
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t);
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t);
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue);
		public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
