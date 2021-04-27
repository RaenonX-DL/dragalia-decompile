/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyChangeQuestClearPartyRegistPopup : CommonPopup
	{
		// Fields
		public PartyChangePopupCell fromSetCell;
		public PartyChangePopupCell toSetCell;
	
		// Constructors
		public PartyChangeQuestClearPartyRegistPopup();
	
		// Methods
		public static PartyChangeQuestClearPartyRegistPopup Create();
		public void InitPopup(PartyList questClearParty, int partyIndex, Action registAction);
	}
}
