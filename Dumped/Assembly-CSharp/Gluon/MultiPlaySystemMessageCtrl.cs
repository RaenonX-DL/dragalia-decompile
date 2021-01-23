/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlaySystemMessageCtrl
	{
		// Fields
		private bool _needsOtherPlayerDisconnectMessage;
		private bool _needsDisconnectOwnMessage;
		private bool _needsRankingDisabledMessage;
		private bool _needsInstructorBonusMessage;
		private List<ulong> _instructorBonusViewerIdList;
	
		// Constructors
		public MultiPlaySystemMessageCtrl();
	
		// Methods
		public void SetupInstructorBonusViewerList(List<ulong> roomViewerIds);
		public bool HasInstructorBonusPlayer();
		public void DisplayDisconnectOwnMessage(MultiPlayErrorEventService.Event e);
		public void DisplayDisconnectOtherPlayerMessage(MultiPlayErrorEventService.Event e, MultiPlayManager.PlayerInfo playerInfo);
		public void DisplayDisableInstructorBonusMessage(ulong disconnectViwerId = 0);
		public void DisplayRankingDisabledMessage();
		public bool NeedsInstructorBonusMessage();
		public bool NeedsDisconnectOwnMessage();
		public bool NeedsOtherPlayerDisconnectMessage();
		public bool NeedsRankingDisabledMessage();
		public void OnClearQuest();
	}
}
