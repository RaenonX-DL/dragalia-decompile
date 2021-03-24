/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipDragonStatus : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject emptyObject;
		[SerializeField]
		private GameObject rootObject;
		[SerializeField]
		private Image dragonIcon;
		[SerializeField]
		private UnityEngine.UI.Text dragonName;
		[SerializeField]
		private UnityEngine.UI.Text hp;
		[SerializeField]
		private UnityEngine.UI.Text attack;
		[SerializeField]
		private PartyEquipStatusIconBar skillIconBar;
		[SerializeField]
		private PartyEquipStatusIconBar[] abilityIconBars;
		private int skillId;
		private int skillLevel;
		private List<int> abilityIds;
		private ElementalType dragonElementalType;
		private ulong dragonKeyId;
		public UnityAction unitLockCallback;
	
		// Constructors
		public PartyEquipDragonStatus();
	
		// Methods
		public void Setup(ulong dragonKeyId);
		public void OnSkillIconPressed();
		public void OnAbilityIconPressed(int index);
		public void OpenDetailScene();
	}
}
