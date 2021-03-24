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
	public class GozTackleUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private List<CharacterId> tackleTargets;
		private List<bool> tackleTargetsSyncFlag;
	
		// Constructors
		public GozTackleUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public void SendGozTackleInit(List<CharacterBase> targets);
		public void SendGozTackleTarget(CharacterBase target, int tackleNo);
		public override void OnReceiveActionPartsNotifyEvent(ActionPartsNotifyEvent recvEvent);
		public CharacterBase GetSyncTarget(int tackleNo);
	}
}
