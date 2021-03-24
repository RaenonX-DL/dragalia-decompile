/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnionBonusDetailPopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Party/Party/UnionBonusDetailPopup";
		[SerializeField]
		private Image unionIcon;
		[SerializeField]
		private UnityEngine.UI.Text unionNameText;
		[SerializeField]
		private Image abilityIcon;
		[SerializeField]
		private UnityEngine.UI.Text abilityNameText;
		[SerializeField]
		private UnityEngine.UI.Text descriptionText;
	
		// Constructors
		public UnionBonusDetailPopup();
	
		// Methods
		public static UnionBonusDetailPopup Create();
		public void Setup(int charaId, UnionAbilityElement unionAbility, AbilityDataElement abilityData);
		public void Setup(int charaId, int unionAbilityId, int abilityId);
		public void Setup(UnionAbilityElement unionAbility, AbilityDataElement abilityData);
	}
}
