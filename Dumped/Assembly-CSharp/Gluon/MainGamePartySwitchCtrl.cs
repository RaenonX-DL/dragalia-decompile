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
	public class MainGamePartySwitchCtrl
	{
		// Fields
		private Dictionary<MainGameCtrl.PartySwitchPhase, WaitOtherPlayersData> _waitOtherPlayersDic;
	
		// Nested types
		private class WaitOtherPlayersData
		{
			// Fields
			public bool isWaitOtherPlayers;
			public float minWaitRemainSec;
			public Action onFinishCallback;
			public MultiPlayWaitingList waitingOtherPlayers;
			public List<int> receiveBuffer;
	
			// Constructors
			public WaitOtherPlayersData();
	
			// Methods
			public void Clear();
		}
	
		// Constructors
		public MainGamePartySwitchCtrl();
	
		// Methods
		public void SetStateIdle(CharacterManager charaManager, DragonTransformCtrl dragonTransform, bool isOnlyOwnParty);
		public void StartWaitOtherPlayers(MainGameCtrl.PartySwitchPhase phase, float minWaitSec, Action onFinishCallback);
		public void StopWaitOtherPlayers(MainGameCtrl.PartySwitchPhase phase);
		public void Update();
		public bool OnReceiveGameStep(GameStepEvent recvEvent);
	}
}
