/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitSkillAndAbilityPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnitDetailSkillInfoCell SkillCell;
		public UnitDetailAbilityInfoCell abilityOneCell;
		public UnitDetailAbilityInfoCell abilityTwoCell;
		[HideInInspector]
		public UnitDetailCanvas parentCanvas;
		private UnitDetailModel.UnitDetailType unitType;
	
		// Constructors
		public UnitSkillAndAbilityPage();
	
		// Methods
		public void SetupSkillAndAbilityPage(UnitDetailModel.UnitDetailType type);
		private void SetSkillInfo();
		private void SetAbilityInfo();
	}
}
