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
	public class UnitAbilityPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject normalPanel;
		public GameObject withEquipPanel;
		[Header]
		[SerializeField]
		public UnitDetailAbilityInfoCell[] mixedPageCellList;
		public UnitDetailAbilityInfoCell[] singlePageCellList;
		[SerializeField]
		private UnityEngine.UI.Text abilityTitleText;
		[HideInInspector]
		public UnitDetailCanvas parentCanvas;
		private UnitDetailModel.UnitDetailType unitType;
		private const int maxCount = 8;
	
		// Constructors
		public UnitAbilityPage();
	
		// Methods
		public void SetupAbilityPage(UnitDetailModel.UnitDetailType type, int index);
		private void SetAbilityInfo(int index);
	}
}
