/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BuffMultiPlayService
	{
		// Fields
		public static readonly int DefaultKey;
		private bool _isDirty;
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private ChangeBuff _tempSendChangeBuffEvent;
		private Regeneration _tmpSendRegeneEvent;
		private Dispel _tmpSendDispelEvent;
		private int _nextMultiPlayKey;
	
		// Constructors
		public BuffMultiPlayService();
		static BuffMultiPlayService();
	
		// Methods
		public void NotifyAddParametersBuff(CharacterBase owner, int type, CharacterBuff.Parameter parameter, float sacrificeShieldConsumeHp);
		public bool IsSyncImmdediately(CharacterBuffType type);
		public void NotifyRemoveParameterBuff(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason);
		public void NotifyAddRegenerationBuff(CharacterBase owner, CharacterBuff.Regeneration regeneration);
		public void NotifyRemoveRegenerationBuff(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason);
		public void NotifyAddGrantBuff(CharacterBase owner, AbilityTargetAction trigger, CharacterBuff.GrantData grant);
		public void NotifyRemoveGrantBuff(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason);
		public void NotifyAddUnifiedParametersBuff(CharacterBase owner, CharacterBuff.UnifiedParameter parameter, float sacrificeShieldConsumeHp);
		public void NotifyRemoveUnifiedParameterBuff(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason);
		public void NotifyRegenerate(CharacterBase owner, Dictionary<CharacterBase, int> froms, CharacterBuffType type, int buffIconId, int heal1, int heal2, int heal3, int heal4, int damage1, bool isFollower, float dragonTimerDamage);
		public void NotifyRemoveBuffExtraDamage(CharacterBase owner, int damage, int actionConditionId, int actionId, string hitAttrLabel, CharacterBase from, float extraElementRate);
		public void NotifyExtraRegenerate(CharacterBase owner, int heal);
		public void NotifyDispelSucceeded(CharacterBase owner, int actionId, CharacterBase from);
		public int CreateMultiPlayKey(CharacterBase owner);
		public void UpdateSendEvent(CharacterBase owner);
		public void SendImmediately(CharacterBase owner);
		public void OnRecieveCurrentBuff(CharacterBase owner, ChangeBuff recvEvent);
		public void OnReceiveRegenerate(CharacterBase owner, Regeneration regene);
		public void OnReceiveRemoveBuffExtraDamage(CharacterBase owner, DebuffExtraDamage recvEvent);
		public void OnReceiveDispel(CharacterBase owner, Dispel recvEvent);
		private void SendCurrentBuff(CharacterBase owner);
		public bool HasSendImmediatelyBuff();
		private void SetDirty();
	}
}
