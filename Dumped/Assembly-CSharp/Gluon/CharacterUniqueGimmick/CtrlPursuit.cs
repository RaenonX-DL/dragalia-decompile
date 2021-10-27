/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlPursuit : CUGCtrlBase
	{
		// Fields
		private CharacterBuffTriggerReactionPursuit reaction;
		private static int _nextTaskId;
	
		// Nested types
		private class CharacterBuffTriggerReactionPursuit : CharacterBuffTriggerReactionBase
		{
			// Fields
			private List<BuffRecord> _buffList;
	
			// Nested types
			private class BuffRecord
			{
				// Fields
				public States State;
				public CharacterBuff.BuffUnion TargetBuff;
				public int Damage;
				public CharacterBase TargetChara;
				public CharacterBase BuffAppender;
				public CollisionHitAttribute HitAttribute;
				public int ActionConditionId;
				public BuffExplosionDataElement BuffExplosionData;
	
				// Nested types
				public enum States
				{
					WaitForRemove = 0,
					Reserved = 1
				}
	
				// Constructors
				public BuffRecord();
			}
	
			// Constructors
			public CharacterBuffTriggerReactionPursuit();
	
			// Methods
			public override void Update();
			public override bool CanAcceptTrigger(ref CharacterAppendBuffTrigger trigger);
			public override void OnAppendBuff(ref CharacterAppendBuffTrigger trigger);
			public override bool CanAcceptTrigger(ref CharacterRemoveBuffTrigger trigger);
			public override void OnRemoveBuff(ref CharacterRemoveBuffTrigger trigger);
			private void ExecRemoveBuffExtraDamage(BuffRecord record);
			private void PlayEffect(CharacterBase target, CharacterBase appender, string effectName, int effectTrigger);
		}
	
		// Constructors
		public CtrlPursuit();
	
		// Methods
		public static int CreateTaskId();
		public static void ResetTaskId();
		public void Setup(EnemyCharacter enemy);
		public override void Update(CharacterBase src);
		public static bool IsPursuitDebuff(int actionConditionId);
	}
}
