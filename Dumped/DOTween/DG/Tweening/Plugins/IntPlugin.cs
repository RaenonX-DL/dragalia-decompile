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
	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions>
	{
		// Constructors
		public IntPlugin();
	
		// Methods
		public override void Reset(TweenerCore<int, int, NoOptions> t);
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative);
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value);
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t);
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t);
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue);
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
