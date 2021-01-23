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
	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions>
	{
		// Constructors
		public UlongPlugin();
	
		// Methods
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t);
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative);
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value);
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t);
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t);
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue);
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
