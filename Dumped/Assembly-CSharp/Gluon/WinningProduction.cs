/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WinningProduction : ProductionBase
	{
		// Fields
		private int winNum;
		[CompilerGenerated]
		private float _winTime_k__BackingField;
		private float[] winAnimStartTime;
		private int winStep;
		[CompilerGenerated]
		private bool _isPlayQuestClear_k__BackingField;
		private string winCueName;
		private string winSeName;
		private string winJingleName;
		private bool isPlayWinVoice;
		private bool endPlay;
		public const float Length = 4.7f;
		public const float UI_START_TIME = 2.2f;
		private List<CharacterBase> characterList;
		private List<Vector3> positionList;
		private List<Quaternion> rotationList;
		private int cameraNo;
	
		// Properties
		public float winTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isPlayQuestClear { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsPlaying { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public int i;
			public WinningProduction __4__this;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _Initialize_b__0(CharacterAnimationEvent animEvent);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<AnimationEvent> __9__28_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _OnSkip_b__28_0(AnimationEvent a, AnimationEvent b);
		}
	
		// Constructors
		public WinningProduction();
	
		// Methods
		public void Initialize();
		public void InitializeCharacter();
		public override bool Update();
		public void PauseCameraAnimation();
		private void OnSkip();
	}
}
