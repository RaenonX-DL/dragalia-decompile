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
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions>
	{
		// Constructors
		public RectPlugin();
	
		// Methods
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t);
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative);
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value);
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t);
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t);
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue);
		public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
