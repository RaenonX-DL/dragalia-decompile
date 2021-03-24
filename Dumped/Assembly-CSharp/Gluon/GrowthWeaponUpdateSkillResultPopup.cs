/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponUpdateSkillResultPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text messageText;
		public Transform cellParentTransform;
		private GrowthUnitEnhanceModel model;
		private const string cellPrefabPath = "Prefabs/OutGame/Growth/GrowthUnitEnhance/GrowthUnitEnhanceSkillAbilityInfoCell";
	
		// Constructors
		public GrowthWeaponUpdateSkillResultPopup();
	
		// Methods
		public static GrowthWeaponUpdateSkillResultPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model, BitArray diffParam);
		private void AddSkillInfo();
		private void AddAbilityInfo(int abilityNo);
	}
}
