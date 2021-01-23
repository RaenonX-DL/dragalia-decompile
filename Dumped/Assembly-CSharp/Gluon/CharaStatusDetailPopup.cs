/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaStatusDetailPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text charaHpParam;
		public UnityEngine.UI.Text charaAtkParam;
		public UnityEngine.UI.Text dragonHpParam;
		public UnityEngine.UI.Text dragonAtkParam;
		public UnityEngine.UI.Text weaponHpParam;
		public UnityEngine.UI.Text weaponAtkParam;
		public UnityEngine.UI.Text fortHpParam;
		public UnityEngine.UI.Text fortAtkParam;
		public UnityEngine.UI.Text abilityHpParam;
		public UnityEngine.UI.Text abilityAtkParam;
		public UnityEngine.UI.Text amuletHpParam;
		public UnityEngine.UI.Text amuletAtkParam;
		public UnityEngine.UI.Text totalHpParam;
		public UnityEngine.UI.Text totalAtkParam;
		public UnityEngine.UI.Text plusHpValueParam;
		public UnityEngine.UI.Text plusAtkValueParam;
		public GameObject plusValueObj;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public CharaStatusDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public CharaStatusDetailPopup();
	
		// Methods
		public static CharaStatusDetailPopup Create(UnitDetailModel.UnitDetailType detailType);
		public void SetCharaStatus(bool isEquipParamPlus);
	}
}
