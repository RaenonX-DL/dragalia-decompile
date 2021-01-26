/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipOverPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private List<Image> charaIconList;
		[SerializeField]
		private List<Image> selectedImageList;
		[SerializeField]
		private Image targetIcon;
		[SerializeField]
		private UnityEngine.UI.Text targetName;
		[SerializeField]
		private Image targetCharaIcon;
		private int selectedIndex;
		private List<int> charaIdList;
	
		// Constructors
		public PartyEquipOverPopup();
	
		// Methods
		public static PartyEquipOverPopup Create();
		public void SetupForWeapon(List<int> charaIdList, int targetWeaponId);
		public void SetupForCrest(List<int> charaIdList, int targetCrestId);
		private void Setup(List<int> charaIdList);
		public void SelectIcon(int index);
		public int GetSelectedCharaId();
		private void SetTargetUnitInfo(GiftType type, int unitId);
	}
}
