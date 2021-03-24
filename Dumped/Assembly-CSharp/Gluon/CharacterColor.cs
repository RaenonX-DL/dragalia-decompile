/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterColor
	{
		// Fields
		private static readonly ColorParam _baseColorDefault;
		private static readonly ColorParam _rimColorDefault;
		private static readonly ColorParam _coverColorDefault;
		[CompilerGenerated]
		private ColorParam _baseColorParam_k__BackingField;
		[CompilerGenerated]
		private ColorParam _rimColorParam_k__BackingField;
		[CompilerGenerated]
		private ColorParam _coverColorParam_k__BackingField;
		public ColorParam smoothColorParam;
		private Process currProcess;
		private Process prevProcess;
		private Process tempProcess;
		private float smoothSec;
		private List<State> stateExecList;
	
		// Properties
		public ColorParam baseColorParam { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ColorParam rimColorParam { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ColorParam coverColorParam { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum State
		{
			None = 0,
			Reset = 1,
			Smooth = 2,
			FromDragon = 3,
			Curse = 4,
			Frostbite = 5,
			Poison = 6,
			Burn = 7,
			Paralysis = 8,
			Flashheat = 9,
			Darkabs = 10,
			Crashwind = 11,
			Destroyfire = 12,
			Darkness = 13,
			SlowMove = 14,
			Freeze = 15,
			Swoon = 16,
			Sleep = 17,
			Break = 18,
			DamageParts = 19,
			DamagePartsDragon = 20,
			Damage = 21,
			DamageDragon = 22,
			HealSp = 23,
			HealHp = 24,
			Invincible = 25
		}
	
		private class Process
		{
			// Fields
			public State state;
			public float elapsedTime;
			public Phase phase;
			public ColorParam fromBaseParam;
			public ColorParam fromRimParam;
			public ColorParam fromCoverParam;
			public ColorParam toBaseParam;
			public ColorParam toRimParam;
			public ColorParam toCoverParam;
	
			// Nested types
			public enum Phase
			{
				Idle = -1,
				ToSetColor = 0,
				ToOriginalColor = 1
			}
	
			// Constructors
			public Process();
	
			// Methods
			public void Copy(Process currProcess);
			public void SetFromParam(ColorParam baseParam, ColorParam rimParam, ColorParam coverParam);
			public void SetToParam(ColorParam baseParam, ColorParam rimParam, ColorParam coverParam);
			public void SetToParam(MainGameGraphic.StatusColorParam colorParam);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<State> __9__26_0;
			public static Comparison<State> __9__26_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetState_b__26_0(State a, State b);
			internal int _SetState_b__26_1(State a, State b);
		}
	
		// Constructors
		public CharacterColor();
		static CharacterColor();
	
		// Methods
		public void Initialize(CharacterBase chara);
		public void Clear();
		private void SetDefault();
		public void SetState(State state);
		public bool IsRimDamageState();
		private void ChangeState(State state);
		public void FinishState(State state);
		public void SetSmooth(ColorParam toBasicColor, float smoothSec);
		public void Update();
		private bool UpdateReset();
		private bool UpdateSmooth();
		private bool UpdateNoColor();
		private bool UpdateColor();
		private bool UpdateBreak();
		private bool UpdateOneshot(float forwardSec, float reverseSec);
		private bool UpdateLoop(float forwardSec, float reverseSec);
		private bool UpdateAbnormalStatus(float forwardSec);
		private float PlayForward(float sec);
		private float PlayReverse(float sec);
		public bool IsActive();
	}
}
