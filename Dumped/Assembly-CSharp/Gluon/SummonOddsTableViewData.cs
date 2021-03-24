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
	public class SummonOddsTableViewData
	{
		// Fields
		public int id;
		public string rate;
		public bool isRateUp;
		public ElementalType elementalType;
		public WeaponType weaponType;
		public string displayName;
		public Rarity rarity;
		public GiftType giftType;
	
		// Constructors
		public SummonOddsTableViewData();
		public SummonOddsTableViewData(AtgenUnitList unitInfo, Rarity rarity, bool isPickup, GiftType giftType);
	}
}
