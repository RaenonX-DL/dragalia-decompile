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
	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions>
	{
		// Constructors
		public Vector3Plugin();
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t);
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative);
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value);
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t);
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t);
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue);
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
