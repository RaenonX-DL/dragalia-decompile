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

// Image 40: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins
{
	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions>
	{
		// Constructors
		public LongPlugin();
	
		// Methods
		public override void Reset(TweenerCore<long, long, NoOptions> t);
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative);
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value);
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t);
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t);
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue);
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
