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

// Image 40: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins
{
	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions>
	{
		// Fields
		private static RectOffset _r;
	
		// Constructors
		public RectOffsetPlugin();
		static RectOffsetPlugin();
	
		// Methods
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t);
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative);
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value);
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t);
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t);
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue);
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
