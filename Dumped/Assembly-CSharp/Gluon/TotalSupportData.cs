/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TotalSupportData
	{
		// Fields
		public SupportData charaData;
		public SupportData dragonData;
		public SupportData weaponData;
		public SupportData[] abilityCrestData;
		public SupportData[] abilityCrestData2;
		public string playerName;
	
		// Constructors
		public TotalSupportData();
	
		// Methods
		public void CopyToData(QuestPrepareData baseData, string playerName = null);
		public void CreateSupportTotalData(FriendGetSupportCharaDetailResponse data);
		private int GetBustAttackLevel(int charaId, int[] manacircleIds);
		private int GetComboLevel(int charaId, int[] manacircleIds);
	}
}
