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
	public class CommonCharaExAbilityData
	{
		// Fields
		public int unitNo;
		public int rarity;
		public int exAbilityId;
		public int category;
		public float abilityType1UpValue0;
		public bool abilityEnable;
		public bool isSecondExAbility;
		public List<UnitData> abilityDuplicateUnit;
	
		// Nested types
		public class UnitData
		{
			// Fields
			public int unitNo;
			public int rarity;
	
			// Constructors
			public UnitData(int unitNo, int rarity);
		}
	
		// Constructors
		public CommonCharaExAbilityData();
	}
}
