/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening
{
	public class DOTween
	{
		// Fields
		public static readonly string Version;
		public static bool useSafeMode;
		public static bool showUnityEditorReport;
		public static float timeScale;
		public static bool useSmoothDeltaTime;
		public static float maxSmoothUnscaledTime;
		internal static RewindCallbackMode rewindCallbackMode;
		private static LogBehaviour _logBehaviour;
		public static bool drawGizmos;
		public static UpdateType defaultUpdateType;
		public static bool defaultTimeScaleIndependent;
		public static AutoPlay defaultAutoPlay;
		public static bool defaultAutoKill;
		public static LoopType defaultLoopType;
		public static bool defaultRecyclable;
		public static Ease defaultEaseType;
		public static float defaultEaseOvershootOrAmplitude;
		public static float defaultEasePeriod;
		internal static DOTweenComponent instance;
		internal static bool isUnityEditor;
		internal static bool isDebugBuild;
		internal static int maxActiveTweenersReached;
		internal static int maxActiveSequencesReached;
		internal static readonly List<TweenCallback> GizmosDelegates;
		internal static bool initialized;
		internal static bool isQuitting;
	
		// Properties
		public static LogBehaviour logBehaviour { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public float v;
			public DOSetter<float> setter;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal float _To_b__0();
			internal void _To_b__1(float x);
		}
	
		// Constructors
		static DOTween();
		public DOTween();
	
		// Methods
		public static IDOTweenInit Init(bool? recycleAllByDefault = default, bool? useSafeMode = default, LogBehaviour? logBehaviour = default);
		private static void AutoInit();
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour);
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity);
		public static void Clear(bool destroy = false);
		public static void ClearCachedTweens();
		public static int Validate();
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime);
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration);
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration);
		public static Tweener To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration);
		public static Tweener To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration);
		public static Tweener To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration);
		public static Tweener To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration);
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration);
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration);
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration);
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration);
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration);
		public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration);
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration);
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration);
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.None | AxisConstraint.X);
		public static Tweener ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration);
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration);
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1f);
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool ignoreZAxis = true, bool fadeOut = true);
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true);
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut);
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations);
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration);
		public static Sequence Sequence();
		public static int CompleteAll(bool withCallbacks = false);
		public static int Complete(object targetOrId, bool withCallbacks = false);
		internal static int CompleteAndReturnKilledTot();
		internal static int CompleteAndReturnKilledTot(object targetOrId);
		internal static int CompleteAndReturnKilledTotExceptFor(params object[] excludeTargetsOrIds);
		public static int FlipAll();
		public static int Flip(object targetOrId);
		public static int GotoAll(float to, bool andPlay = false);
		public static int Goto(object targetOrId, float to, bool andPlay = false);
		public static int KillAll(bool complete = false);
		public static int KillAll(bool complete, params object[] idsOrTargetsToExclude);
		public static int Kill(object targetOrId, bool complete = false);
		public static int PauseAll();
		public static int Pause(object targetOrId);
		public static int PlayAll();
		public static int Play(object targetOrId);
		public static int Play(object target, object id);
		public static int PlayBackwardsAll();
		public static int PlayBackwards(object targetOrId);
		public static int PlayBackwards(object target, object id);
		public static int PlayForwardAll();
		public static int PlayForward(object targetOrId);
		public static int PlayForward(object target, object id);
		public static int RestartAll(bool includeDelay = true);
		public static int Restart(object targetOrId, bool includeDelay = true, float changeDelayTo = -1f);
		public static int Restart(object target, object id, bool includeDelay = true, float changeDelayTo = -1f);
		public static int RewindAll(bool includeDelay = true);
		public static int Rewind(object targetOrId, bool includeDelay = true);
		public static int SmoothRewindAll();
		public static int SmoothRewind(object targetOrId);
		public static int TogglePauseAll();
		public static int TogglePause(object targetOrId);
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false);
		public static int TotalPlayingTweens();
		public static List<Tween> PlayingTweens(List<Tween> fillableList = null);
		public static List<Tween> PausedTweens(List<Tween> fillableList = null);
		public static List<Tween> TweensById(object id, bool playingOnly = false, List<Tween> fillableList = null);
		public static List<Tween> TweensByTarget(object target, bool playingOnly = false, List<Tween> fillableList = null);
		private static void InitCheck();
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions;
	}
}
