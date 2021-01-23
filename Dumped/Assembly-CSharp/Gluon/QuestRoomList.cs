/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestRoomList : TableViewCell<Gluon.RoomListData>
	{
		// Fields
		[SerializeField]
		private QuestRoomListUI shortRoomUI;
		[SerializeField]
		private QuestRoomListUI longRoomUI;
		[SerializeField]
		private GameObject shortRoot;
		[SerializeField]
		private GameObject longRoot;
		[SerializeField]
		private UnityEngine.UI.Text roomPurposeText;
		[SerializeField]
		private UnityEngine.UI.Text requirePowerText;
		[SerializeField]
		private UnityEngine.UI.Text requirePowerTitle;
		[SerializeField]
		private Image[] enableElementals;
		[SerializeField]
		private GameObject[] enableWeaponRoots;
		[SerializeField]
		private Image[] enableWeaponTypes;
		[SerializeField]
		private GameObject requirePowerRedRoot;
		[SerializeField]
		private UnityEngine.UI.Text requirePowerRedText;
		[SerializeField]
		private UnityEngine.UI.Text requirePowerRedTitle;
		[SerializeField]
		private Image[] enableElementalRedImages;
		[SerializeField]
		private Image[] enableWeaponTypeRedImages;
		[SerializeField]
		public float shortHeight;
		[SerializeField]
		public float longHeight;
		public UnityAction<int> buttonPressedAction;
		protected QuestDetailInfoPopup detailInfoPopup;
		private const int MAX_MEMBER_NUM = 4;
		private int questId;
		private string questNumberStr;
		private QuestSelectScene.Difficulty difficult;
		private const float eventElementIconYPos = -8f;
	
		// Constructors
		public QuestRoomList();
	
		// Methods
		public override void UpdateContent(RoomListData itemData);
		public void SetDisablePress();
		public void OnButtonPressed();
		public void OnDetailButtonPressed();
		protected void OnClickDetailPopupClose();
		public static bool IsPowerFullfilled(int questId, AtgenEntryConditions entryConditions);
		public static bool IsElementFullfilled(bool isRaidBattle, bool isLimitedElementalQuest, AtgenEntryConditions entryConditions);
		public static bool IsWeaponTypeFullfilled(bool isRaidBattle, AtgenEntryConditions entryConditions);
	}
}
