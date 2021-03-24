/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening
{
	public static class TweenSettingsExtensions
	{
		// Extension methods
		public static T SetAutoKill<T>(this T t)
			where T : Tween;
		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion)
			where T : Tween;
		public static T SetId<T>(this T t, object objectId)
			where T : Tween;
		public static T SetId<T>(this T t, string stringId)
			where T : Tween;
		public static T SetId<T>(this T t, int intId)
			where T : Tween;
		public static T SetTarget<T>(this T t, object target)
			where T : Tween;
		public static T SetLoops<T>(this T t, int loops)
			where T : Tween;
		public static T SetLoops<T>(this T t, int loops, LoopType loopType)
			where T : Tween;
		public static T SetEase<T>(this T t, Ease ease)
			where T : Tween;
		public static T SetEase<T>(this T t, Ease ease, float overshoot)
			where T : Tween;
		public static T SetEase<T>(this T t, Ease ease, float amplitude, float period)
			where T : Tween;
		public static T SetEase<T>(this T t, AnimationCurve animCurve)
			where T : Tween;
		public static T SetEase<T>(this T t, EaseFunction customEase)
			where T : Tween;
		public static T SetRecyclable<T>(this T t)
			where T : Tween;
		public static T SetRecyclable<T>(this T t, bool recyclable)
			where T : Tween;
		public static T SetUpdate<T>(this T t, bool isIndependentUpdate)
			where T : Tween;
		public static T SetUpdate<T>(this T t, UpdateType updateType)
			where T : Tween;
		public static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate)
			where T : Tween;
		public static T OnStart<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnPlay<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnPause<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnRewind<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnUpdate<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnStepComplete<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnComplete<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnKill<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnWaypointChange<T>(this T t, TweenCallback<int> action)
			where T : Tween;
		public static T SetAs<T>(this T t, Tween asTween)
			where T : Tween;
		public static T SetAs<T>(this T t, TweenParams tweenParams)
			where T : Tween;
		public static Sequence Append(this Sequence s, Tween t);
		public static Sequence Prepend(this Sequence s, Tween t);
		public static Sequence Join(this Sequence s, Tween t);
		public static Sequence Insert(this Sequence s, float atPosition, Tween t);
		public static Sequence AppendInterval(this Sequence s, float interval);
		public static Sequence PrependInterval(this Sequence s, float interval);
		public static Sequence AppendCallback(this Sequence s, TweenCallback callback);
		public static Sequence PrependCallback(this Sequence s, TweenCallback callback);
		public static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback);
		public static T From<T>(this T t)
			where T : Tweener;
		public static T From<T>(this T t, bool isRelative)
			where T : Tweener;
		public static T SetDelay<T>(this T t, float delay)
			where T : Tween;
		public static T SetRelative<T>(this T t)
			where T : Tween;
		public static T SetRelative<T>(this T t, bool isRelative)
			where T : Tween;
		public static T SetSpeedBased<T>(this T t)
			where T : Tween;
		public static T SetSpeedBased<T>(this T t, bool isSpeedBased)
			where T : Tween;
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping);
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping);
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false);
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping);
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false);
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping);
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false);
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true);
		public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly);
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping);
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null);
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping);
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false);
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None);
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None, AxisConstraint lockRotation = AxisConstraint.None);
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = default, Vector3? up = default);
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = default, Vector3? up = default);
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default);
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = default, Vector3? up = default);
	}
}
