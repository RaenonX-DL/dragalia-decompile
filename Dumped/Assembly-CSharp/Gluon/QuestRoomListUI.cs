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
	public class QuestRoomListUI : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text questNumber;
		[SerializeField]
		private Image elementsSprite;
		[SerializeField]
		private UnityEngine.UI.Text questName;
		[SerializeField]
		private Image eventElementsSprite;
		[SerializeField]
		private UnityEngine.UI.Text eventQuestName;
		[SerializeField]
		private Image questThumbnailImage;
		[SerializeField]
		private UiImageExchanger cellFrame;
		[SerializeField]
		private CommonIcon charaIcon;
		[SerializeField]
		private UnityEngine.UI.Text userLevel;
		[SerializeField]
		private UnityEngine.UI.Text userName;
		[SerializeField]
		private Image[] numberOfPeopleImage;
		[SerializeField]
		private List<Sprite> numberOfPeopleSprite;
		[SerializeField]
		private Image selectArrow;
		[SerializeField]
		private Image grayoutTex;
		[Header]
		[SerializeField]
		public GameObject battlePowerRoot;
		public Image battlePowerFrame;
		public UnityEngine.UI.Text battlePowerText;
		public CircleOutline battlePowerOutline;
		public GameObject requiredBattlePowerIcon;
		public GameObject recommendedBattlePowerIcon;
		[SerializeField]
		protected Color requiredBackGroundColor;
		[SerializeField]
		protected Color recommendedBackGroundColor;
		[SerializeField]
		protected Color requiredOutlineColor;
		[SerializeField]
		protected Color recommendedOutlineColor;
		[SerializeField]
		protected Color lackOfPartyPowerColor;
		[SerializeField]
		protected Color defaultPowerColor;
		[Header]
		[SerializeField]
		public GameObject[] needBPFrameList;
		[SerializeField]
		private Image[] bpBaseImages;
		[SerializeField]
		private Image[] bpOnImages;
		[SerializeField]
		private Image[] bpRedImages;
		[Header]
		[SerializeField]
		public Button cellButton;
		public GameObject detailButtonGO;
		[Header]
		[SerializeField]
		private GameObject questItemIconRoot;
		[SerializeField]
		private Image questItemIconImage;
		[SerializeField]
		private UnityEngine.UI.Text questItemNumText;
		[Header]
		[SerializeField]
		private GameObject guildIconRoot;
		private const int MAX_MEMBER_NUM = 4;
		private int questId;
		private QuestSelectScene.Difficulty difficult;
	
		// Properties
		public Image SelectArrow { get; }
		public GameObject blackObjectGO { get; }
	
		// Constructors
		public QuestRoomListUI();
	
		// Methods
		public void UpdateContent(RoomListData itemData);
		public void GreyOutSetting();
		public void SetDisablePress();
	}
}
