/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 40: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening
{
	public static class TweenExtensions
	{
		// Extension methods
		public static void Complete(this Tween t);
		public static void Complete(this Tween t, bool withCallbacks);
		public static void Flip(this Tween t);
		public static void ForceInit(this Tween t);
		public static void Goto(this Tween t, float to, bool andPlay = false);
		public static void Kill(this Tween t, bool complete = false);
		public static T Pause<T>(this T t)
			where T : Tween;
		public static T Play<T>(this T t)
			where T : Tween;
		public static void PlayBackwards(this Tween t);
		public static void PlayForward(this Tween t);
		public static void Restart(this Tween t, bool includeDelay = true, float changeDelayTo = -1f);
		public static void Rewind(this Tween t, bool includeDelay = true);
		public static void SmoothRewind(this Tween t);
		public static void TogglePause(this Tween t);
		public static void GotoWaypoint(this Tween t, int waypointIndex, bool andPlay = false);
		public static YieldInstruction WaitForCompletion(this Tween t);
		public static YieldInstruction WaitForRewind(this Tween t);
		public static YieldInstruction WaitForKill(this Tween t);
		public static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops);
		public static YieldInstruction WaitForPosition(this Tween t, float position);
		public static Coroutine WaitForStart(this Tween t);
		public static int CompletedLoops(this Tween t);
		public static float Delay(this Tween t);
		public static float Duration(this Tween t, bool includeLoops = true);
		public static float Elapsed(this Tween t, bool includeLoops = true);
		public static float ElapsedPercentage(this Tween t, bool includeLoops = true);
		public static float ElapsedDirectionalPercentage(this Tween t);
		public static bool IsActive(this Tween t);
		public static bool IsBackwards(this Tween t);
		public static bool IsComplete(this Tween t);
		public static bool IsInitialized(this Tween t);
		public static bool IsPlaying(this Tween t);
		public static int Loops(this Tween t);
		public static Vector3 PathGetPoint(this Tween t, float pathPercentage);
		public static Vector3[] PathGetDrawPoints(this Tween t, int subdivisionsXSegment = 10);
		public static float PathLength(this Tween t);
	}
}
