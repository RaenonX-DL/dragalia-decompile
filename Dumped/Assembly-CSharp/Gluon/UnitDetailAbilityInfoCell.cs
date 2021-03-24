/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailAbilityInfoCell : UnitDetailInfoBaseCell
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text exAbilityDescription;
		public static bool startBatch;
		private ElementalType elementalType;
		private bool isAbility;
		private AbilityPageData abilityPageData;
		private bool isFirstAbility;
	
		// Constructors
		public UnitDetailAbilityInfoCell();
		static UnitDetailAbilityInfoCell();
	
		// Methods
		public override void IconPressed();
		public void SetAbilityInfo(AbilityConst.UnitType giftType, int abilityId, bool isAbilityEnabled, ElementalType type);
		public void SetAbilityInfo(AbilityPageData data);
		public void SetExAbilityInfo(int abilityId, bool isAbilityEnabled);
	}
}
