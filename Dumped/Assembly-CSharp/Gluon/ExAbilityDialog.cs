/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExAbilityDialog : CommonPopup
	{
		// Fields
		public ExAbilityDialogListBase[] dialogListBase;
	
		// Constructors
		public ExAbilityDialog();
	
		// Methods
		public static ExAbilityDialog Create(string dialogPath, bool showBlackLayer = true);
		public void SetupExAbiltyDialog(PartyList partyList);
		public void SetupExAbiltyDialog(List<MatchingRoomPlayerData.CharaSimpleSyncData> charaSimpleSyncDatas);
		public void SetupExAbiltyDialog(CommonPartyPowerCalculateData[] questPartyData);
	}
}
