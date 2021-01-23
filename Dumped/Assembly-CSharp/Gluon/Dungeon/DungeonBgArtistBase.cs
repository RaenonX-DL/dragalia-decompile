/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonBgArtistBase : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private bool disableInIngameProduction;
		public const float cycleTimeScaleDefault = 1f;
		private static float cycleTimeScaleNow;
	
		// Constructors
		public DungeonBgArtistBase();
		static DungeonBgArtistBase();
	
		// Methods
		protected virtual void Awake();
		protected bool IsPauseUpdate();
		public static void SetCycleTimeScale(float scale);
		protected float GetDeltaTime();
		protected float GetCurrentCurveValue(AnimationCurve curve, float cycleNow, float cycleMax);
	}
}
