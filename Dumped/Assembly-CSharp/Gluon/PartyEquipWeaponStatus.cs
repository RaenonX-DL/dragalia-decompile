/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipWeaponStatus : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image weaponIcon;
		[SerializeField]
		private Image skinIcon;
		[SerializeField]
		private UnityEngine.UI.Text weaponName;
		[SerializeField]
		private UnityEngine.UI.Text hp;
		[SerializeField]
		private UnityEngine.UI.Text attack;
		[SerializeField]
		private PartyEquipStatusIconBar skillIconBar;
		[SerializeField]
		private PartyEquipStatusIconBar[] abilityIconBars;
		private ElementalType weaponElementalType;
		private int skillId;
		private int skillLevel;
		private int skillMaxLevel;
		private bool isNotMatchElement;
		private List<int> abilityIds;
		private int weaponBodyId;
		private int charaId;
	
		// Constructors
		public PartyEquipWeaponStatus();
	
		// Methods
		public void Setup(int charaId, int weaponBodyId, int weaponSkinId);
		public void OnSkillIconPressed();
		public void OnAbilityIconPressed(int index);
		public void OpenDetailScene();
	}
}
