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
	public class SummonResultItemData
	{
		// Fields
		public GiftType giftType;
		public int id;
		public bool isNew;
		public Rarity rarity;
		public Rarity viewRarityForBoxSummon;
		public int moonCount;
		public int originalCharaId;
		public int priority;
	
		// Constructors
		public SummonResultItemData();
	
		// Methods
		public void UpdateDataFromResponse(AtgenResultUnitList resultUnitData);
		public void UpdateDataFromResponse(AtgenDrawDetails detail);
		public bool IsNewCharaOrAwakening();
		public void UpdateDataFromResponse(AtgenRedoableSummonResultUnitList resultUnitData);
	}
}
