/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayRebornCtrl
	{
		// Fields
		private Dictionary<int, ActorData> _actorDic;
		private NotifyCharacter.UpdateRebornTimerCountParam _tmpNotifyParam;
		private RebornEvent tmpRebornEvent;
	
		// Nested types
		private class ActorData
		{
			// Fields
			public float elapsedTime;
			public bool wasShowFirst;
			public List<CharacterBase> targetCharas;
	
			// Constructors
			public ActorData();
		}
	
		// Constructors
		public MultiPlayRebornCtrl();
	
		// Methods
		public void OnReceiveRebornEvent(int actorId, RebornEvent recvEvent);
		public void SendStartWaitReborn(List<CharacterBase> targetCharas);
		public void SendReborn(List<CharacterBase> targetCharas);
		public void Update();
		public int GetOtherPlayerRebornCharacterCount(int actorId);
		public int GetOtherPlayerRebornProcessCount(int actorId);
		public bool IsAnyOtherPlayerRemainRebornCount(int limit);
	}
}
