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
	public class MatchingRoomCellPartyDetailPopupCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon characterIcon;
		public CommonIcon dragonIcon;
		public GameObject noDragonMark;
		public CommonIcon weaponIcon;
		public CommonIcon[] amuletIcon;
		public GameObject[] noAmuletMark;
		public CommonExAbilityCell[] exAbilityCells;
		[Header]
		[SerializeField]
		public Transform charaDecoNode;
		public Transform dragonDecoNode;
		public Transform weaponDecoNode;
		public Transform[] amuletDecoNode;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text characterNameText;
		public UnityEngine.UI.Text plusValText;
		public UnityEngine.UI.Text manaCircleText;
		private MatchingRoomPlayerData data;
		private int memberIndex;
		private const int anuletNum = 5;
		private CommonIconListSortDeco charaDeco;
		private CommonIconListSortDeco dragonDeco;
		private CommonIconListSortDeco weaponDeco;
		private CommonIconListSortDeco[] amuletDeco;
	
		// Constructors
		public MatchingRoomCellPartyDetailPopupCell();
	
		// Methods
		public void SetupWithMatchingDetailData(MatchingRoomPlayerData data, int memberIndex);
		private void InitWithData();
		private void SetAmulet(int index, UnitDetailModel.AmuletDetailData abilityCrestData, int slotNum, int maxSlotNum);
	}
}
