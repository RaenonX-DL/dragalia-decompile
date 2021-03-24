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

namespace DG.Tweening.CustomPlugins
{
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions>
	{
		// Fields
		private static PureQuaternionPlugin _plug;
	
		// Constructors
		public PureQuaternionPlugin();
	
		// Methods
		public static PureQuaternionPlugin Plug();
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t);
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative);
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value);
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t);
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t);
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue);
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
	}
}
