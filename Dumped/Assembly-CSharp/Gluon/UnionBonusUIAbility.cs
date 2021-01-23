/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnionBonusUIAbility : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image unionIcon;
		[SerializeField]
		private UnityEngine.UI.Text abilityNameText;
		private int charaId;
		private UnionAbilityElement unionAbility;
		private AbilityDataElement abilityData;
	
		// Constructors
		public UnionBonusUIAbility();
	
		// Methods
		public void Setup(int charaId, UnionAbilityElement unionAbility, AbilityDataElement abilityData);
		public void OnPressed();
	}
}
