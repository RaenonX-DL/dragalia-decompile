/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening
{
	public class TweenParams
	{
		// Fields
		public static readonly TweenParams Params;
		internal object id;
		internal object target;
		internal UpdateType updateType;
		internal bool isIndependentUpdate;
		internal TweenCallback onStart;
		internal TweenCallback onPlay;
		internal TweenCallback onRewind;
		internal TweenCallback onUpdate;
		internal TweenCallback onStepComplete;
		internal TweenCallback onComplete;
		internal TweenCallback onKill;
		internal TweenCallback<int> onWaypointChange;
		internal bool isRecyclable;
		internal bool isSpeedBased;
		internal bool autoKill;
		internal int loops;
		internal LoopType loopType;
		internal float delay;
		internal bool isRelative;
		internal Ease easeType;
		internal EaseFunction customEase;
		internal float easeOvershootOrAmplitude;
		internal float easePeriod;
	
		// Constructors
		public TweenParams();
		static TweenParams();
	
		// Methods
		public TweenParams Clear();
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true);
		public TweenParams SetId(object id);
		public TweenParams SetTarget(object target);
		public TweenParams SetLoops(int loops, LoopType? loopType = default);
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = default, float? period = default);
		public TweenParams SetEase(AnimationCurve animCurve);
		public TweenParams SetEase(EaseFunction customEase);
		public TweenParams SetRecyclable(bool recyclable = true);
		public TweenParams SetUpdate(bool isIndependentUpdate);
		public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false);
		public TweenParams OnStart(TweenCallback action);
		public TweenParams OnPlay(TweenCallback action);
		public TweenParams OnRewind(TweenCallback action);
		public TweenParams OnUpdate(TweenCallback action);
		public TweenParams OnStepComplete(TweenCallback action);
		public TweenParams OnComplete(TweenCallback action);
		public TweenParams OnKill(TweenCallback action);
		public TweenParams OnWaypointChange(TweenCallback<int> action);
		public TweenParams SetDelay(float delay);
		public TweenParams SetRelative(bool isRelative = true);
		public TweenParams SetSpeedBased(bool isSpeedBased = true);
	}
}
