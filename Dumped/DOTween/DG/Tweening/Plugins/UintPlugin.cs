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
	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions>
	{
		// Constructors
		public UintPlugin();
	
		// Methods
		public override void Reset(TweenerCore<uint, uint, UintOptions> t);
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative);
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value);
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t);
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t);
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue);
		public override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
