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
	public class CharacterTriggerCtrl
	{
		// Fields
		private List<CharacterBuffTriggerReactionBase> _reactions;
	
		// Constructors
		public CharacterTriggerCtrl();
	
		// Methods
		public void RegisterReaction(CharacterBuffTriggerReactionBase reaction);
		public void UnregisterReaction(CharacterBuffTriggerReactionBase reaction);
		public void Update();
		public void OnAppendBuff(ref CharacterAppendBuffTrigger trigger);
		public void OnRemoveBuff(ref CharacterRemoveBuffTrigger trigger);
	}
}
