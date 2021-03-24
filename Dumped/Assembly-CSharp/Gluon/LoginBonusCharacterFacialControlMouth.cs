/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LoginBonusCharacterFacialControlMouth : SimpleCharacterFacialControlBase
	{
		// Fields
		public const string StateTriggerNone = "None";
		public const string StateTriggerIdle = "Idle";
		public const string StateTriggerSmile = "Smile";
		public const string StateTriggerTalk = "Talk";
		private State _state;
		private float mouthTime;
		public float mouthFrame;
	
		// Nested types
		private enum State
		{
			None = 0,
			Idle = 1,
			Smile = 2,
			Talk = 3
		}
	
		// Constructors
		public LoginBonusCharacterFacialControlMouth();
	
		// Methods
		protected override void OnSetup(out Vector2 defaultOffset);
		protected override bool OnLateUpdate(out Vector2 outTextureOffset);
		private void SetState(State state);
		protected override void OnTrigger(string triggerName);
	}
}
