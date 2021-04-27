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
	public class PartyEquipSetPopupCell : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text nameText;
		public CommonUnitIcon weaponIcon;
		public CommonUnitIcon dragonIcon;
		public GameObject dragonEmptyIconObject;
		public CommonUnitIcon[] crestIcons;
		public GameObject[] crestEmptyIconObjects;
		public Image[] unionIcons;
		public Action<int> selectCallBack;
		public Action<int, string> registCallBack;
		private int charaId;
		private int dataIndex;
		private bool isEquipData;
		private bool isRegistPopupCellData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public PartyEquipSetNameEditPopup popup;
			public PartyEquipSetPopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _OnNameEditButtonPressed_b__0();
			internal void _OnNameEditButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public PartyEquipSetRegistPopup popup;
			public PartyEquipSetPopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _OnRegistButtonPressed_b__0();
			internal void _OnRegistButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public PartyEquipStatusPopup popup;
			public PartyEquipSetPopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _OnDetailButtonPressed_b__0();
			internal void _OnDetailButtonPressed_b__1();
		}
	
		// Constructors
		public PartyEquipSetPopupCell();
	
		// Methods
		public void SetupSetDataCell(int charaId, int index, bool isRegistPopupCellData = false);
		public void SetupEquipDataCell(int charaId);
		private void SetupCellIcons(int charaId, int weaponId, ulong dragonKeyId, int[] crestIds);
		public void OnNameEditButtonPressed();
		public void OnRegistButtonPressed();
		public void OnSelectButtonPressed();
		public void OnDetailButtonPressed();
		public void OnDragonIconPressed();
		public void OnWeaponIconPressed();
		public void OnCrestIconPressed(int tag);
	}
}
