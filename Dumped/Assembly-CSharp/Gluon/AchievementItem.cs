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
	public class AchievementItem : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image clearIcon;
		[SerializeField]
		private UnityEngine.UI.Text itemText;
	
		// Nested types
		public enum AchievementType
		{
			charaLevel = 0,
			charaManaCircle = 1,
			weaponLevel = 2,
			weaponLimitBreak = 3,
			amuletLevel = 4,
			amuletLimitBreak = 5,
			dragonLevel = 6,
			dragonLimitBreak = 7,
			dragonFriendShip = 8
		}
	
		// Constructors
		public AchievementItem();
	
		// Methods
		public void SetItem(bool isClear, string str);
		public void SetItem(AchievementType type);
	}
}
