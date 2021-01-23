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
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 40: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins
{
	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
	{
		// Fields
		public const float MinLookAhead = 0.0001f;
	
		// Constructors
		public PathPlugin();
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t);
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative);
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get();
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value);
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t);
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t);
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue);
		public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
		public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice);
	}
}
