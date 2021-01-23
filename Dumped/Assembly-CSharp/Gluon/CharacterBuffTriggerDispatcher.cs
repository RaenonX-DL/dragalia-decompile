/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class CharacterBuffTriggerDispatcher
	{
		// Methods
		public static void OnAppendBuff(CharacterBase owner, ref CharacterBuff.BuffUnion buff);
		public static void OnPreRemoveBuff(CharacterBase owner, ref CharacterBuff.BuffUnion buff, RemoveBuffReason reason);
		public static void OnPostRemoveBuff(CharacterBase owner, RemoveBuffReason reason = RemoveBuffReason.Other);
		public static bool IsRemoveTriggerBuff(ref CharacterBuff.BuffUnion buff);
		private static void CheckAbilityForBuffDisappeared(CharacterBase owner, int buffConditionId, RemoveBuffReason reason = RemoveBuffReason.Other);
	}
}
