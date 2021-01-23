/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterBuffTriggerReactionBomb : CharacterBuffTriggerReactionBase
	{
		// Fields
		private ActionContainer _container;
		private RemoveBuffTriggerBombData _partsData;
		private CollisionHitAttribute _hitAttribute;
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
		public CharacterBuffTriggerReactionBomb(int actionId, int skillId, string convertedHitAttrLabel, ActionContainer container, RemoveBuffTriggerBombData partsData);
	
		// Methods
		public override void Update();
		public override void OnAppendBuff(ref CharacterAppendBuffTrigger trigger);
		public override bool CanAcceptTrigger(ref CharacterRemoveBuffTrigger trigger);
		public override void OnRemoveBuff(ref CharacterRemoveBuffTrigger trigger);
		private void ExecDebuffExtraDamage(BuffRecord record);
		private void PlayEffect(CharacterBase target, CharacterBase appender, string effectName);
	}
}
