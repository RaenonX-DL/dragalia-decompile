/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterBuffTriggerReactionBase
	{
		// Fields
		[CompilerGenerated]
		private int _ActionId_k__BackingField;
		[CompilerGenerated]
		private int _ActionConditionId_k__BackingField;
	
		// Properties
		public int ActionId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int ActionConditionId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CharacterBuffTriggerReactionBase(int actionId, int actionConditionId);
	
		// Methods
		public virtual void Update();
		public virtual bool CanAcceptTrigger(ref CharacterAppendBuffTrigger trigger);
		public virtual void OnAppendBuff(ref CharacterAppendBuffTrigger trigger);
		public virtual bool CanAcceptTrigger(ref CharacterRemoveBuffTrigger trigger);
		public virtual void OnRemoveBuff(ref CharacterRemoveBuffTrigger trigger);
	}
}
