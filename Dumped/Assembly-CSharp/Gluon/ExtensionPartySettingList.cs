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
	public static class ExtensionPartySettingList
	{
		// Methods
		public static int GetAbilityCrestId(PartyUnitList unitList, int typeNo, int index);
	
		// Extension methods
		public static int GetWeapon(this PartySettingList item);
		public static int GetCrest(this PartySettingList self, int typeNo, int num);
		public static void SetData(this PartySettingList self, int unitNo, QuestPrepareData partyData);
		public static void SetData(this PartySettingList self, PartySettingList dest);
		public static void SetData(this PartySettingList self, PartyUnitList unitList);
	}
}
