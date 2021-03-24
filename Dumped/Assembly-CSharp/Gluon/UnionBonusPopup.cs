/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnionBonusPopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Party/Party/UnionBonusPopup";
		[SerializeField]
		private UnityEngine.UI.Text explainText;
		[Header]
		[SerializeField]
		private Transform unionBonusParent;
		[SerializeField]
		private UnionBonusUIChara unionBonusUIChara;
		[Header]
		[SerializeField]
		private UnionBonusUIChara unionBonusCellBase;
	
		// Nested types
		public class UnionBonusInfo
		{
			// Fields
			public int charaMasterId;
			public Rarity charaRarity;
			public List<CommonUnionAbilityData> abilityList;
	
			// Constructors
			public UnionBonusInfo(int charaMasterId, Rarity charaRarity, List<CommonUnionAbilityData> abilityList);
		}
	
		// Constructors
		public UnionBonusPopup();
	
		// Methods
		public static UnionBonusPopup Create();
		public void InitSetting(List<UnionBonusInfo> unionBonusInfoList);
		public void InitSetting(List<UnionAbilityElement> unionBonusAbilityList);
	}
}
