/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleSkillAbilityDetailPopup : CommonPopup
	{
		// Fields
		public Image iconImage;
		public UnityEngine.UI.Text nameText;
		public UnityEngine.UI.Text detailText;
		public UnityEngine.UI.Text levelText;
	
		// Nested types
		public enum PopupType
		{
			None = 0,
			Skill = 1,
			Ability = 2,
			ExAbility = 3
		}
	
		// Constructors
		public GrowthManaCircleSkillAbilityDetailPopup();
	
		// Methods
		public static GrowthManaCircleSkillAbilityDetailPopup Create(string dialogPath, bool showBlackLayer = true);
		public void SetSkillIconImage(PopupType type, string iconName);
		public void SetAbilityIconImage(PopupType type, string iconName);
		public void SetNameText(string name);
		public void SetDetailText(string detail);
		public void SetLevelText(string level);
	}
}
