/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipStatusIconBar : MonoBehaviour
	{
		// Fields
		public Image charaBase;
		public Image amuletBase;
		public Image dragonBase;
		public Image weaponBase;
		public Image skillBase;
		public UnityEngine.UI.Text nameText;
		public Image icon;
		[FormerlySerializedAs]
		public Image lockIcon;
		[FormerlySerializedAs]
		public Image lockIconImage;
		public Image notUseImage;
		public GameObject skinIconObj;
	
		// Constructors
		public PartyEquipStatusIconBar();
	
		// Methods
		public void SetBaseImage(PartyEquipSkillAbilityData.AbilityType type);
	}
}
