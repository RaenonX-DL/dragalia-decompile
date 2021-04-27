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
	public class MultiPlayRebornCtrl
	{
		// Fields
		private Dictionary<CharacterBase, CharaData> _charaDic;
		private NotifyCharacter.UpdateRebornTimerCountParam _tmpNotifyParam;
		private RebornEvent tmpRebornEvent;
	
		// Nested types
		private class CharaData
		{
			// Fields
			public float elapsedTime;
			public bool wasShowFirst;
	
			// Constructors
			public CharaData();
		}
	
		// Constructors
		public MultiPlayRebornCtrl();
	
		// Methods
		public void OnReceiveRebornEvent(int actorId, RebornEvent recvEvent);
		public void SendStartWaitReborn(List<CharacterBase> targetCharas, bool isAbilityReborn);
		public void SendReborn(List<Tuple<CharacterBase, float>> rebornCharaInfos, bool isAbilityReborn);
		public void Update();
		public int GetOtherPlayerSystemRebornCharacterCount(int actorId);
		public int GetOtherPlayerSystemRebornProcessCount(int actorId);
	}
}
