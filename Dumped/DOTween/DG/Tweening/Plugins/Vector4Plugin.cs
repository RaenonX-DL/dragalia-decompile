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
	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions>
	{
		// Constructors
		public Vector4Plugin();
	
		// Methods
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t);
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative);
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value);
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t);
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t);
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue);
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
