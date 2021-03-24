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
	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions>
	{
		// Constructors
		public Vector2Plugin();
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t);
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative);
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value);
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t);
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t);
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue);
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
