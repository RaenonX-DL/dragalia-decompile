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
	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions>
	{
		// Constructors
		public DoublePlugin();
	
		// Methods
		public override void Reset(TweenerCore<double, double, NoOptions> t);
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative);
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value);
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t);
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t);
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue);
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
