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
	public class CommonFriendListCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon charaIcon;
		public CommonIcon skillIcon;
		public UnityEngine.UI.Text plusText;
		public Transform charaListSortDecoTrans;
		private CommonIconListSortDeco deco;
		[Header]
		[SerializeField]
		public Image anotherNameIcon;
		public UnityEngine.UI.Text anotherNameText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text playerLevelText;
		public UnityEngine.UI.Text usernameText;
		public UnityEngine.UI.Text lastPlayTimeText;
		[Header]
		[SerializeField]
		public Image frameImage;
		public UnityEngine.UI.Text lastPlayTimeTextInDialog;
		[Header]
		[SerializeField]
		public GameObject guildGO;
		public UnityEngine.UI.Text guildNameText;
		public RawImage guildEmblem;
		[SerializeField]
		private GameObject skillTextRoot;
		[SerializeField]
		private UnityEngine.UI.Text skillText;
		[SerializeField]
		private GameObject skillTextWithSelectButtonRoot;
		[SerializeField]
		private UnityEngine.UI.Text skillTextWithSelectButton;
		[SerializeField]
		private bool _isShowSelectButton;
		[SerializeField]
		private Image friendIcon;
		[SerializeField]
		private GameObject manaPointRootObj;
		private CommonFriendListCellData data;
		private bool isInDialogStyle;
		private const string prefabPath = "Prefabs/OutGame/CommonFriendListCell";
		private UnityEngine.UI.Text manaPointText;
		private const float ShortSkillDescTextWidth = 128f;
		private Button onClickEventButton;
	
		// Properties
		public bool isShowSelectButton { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__34_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _UpdateContent_b__34_0();
		}
	
		// Constructors
		public CommonFriendListCell();
	
		// Methods
		private static CommonFriendListCell Create(CommonFriendListCellData data, Transform parent, bool isInDialogStyle = false);
		public void SetupByData(CommonFriendListCellData data, bool isInDialogStyle = false);
		private void Start();
		public void UpdateContent(CommonFriendListCellData data, bool isShortSkillDesc = false);
		public void SetTouchEventButtonObjectReference(Button button);
		public void SetManaPointDisplay(CommonFriendListCellData data);
		public static string LastPlayTimeToString(long lastPlayTime);
		public void OnSupportCharacterIconPressed();
		public void SetUnitDetailModelOnCreated(UnityAction onCreated);
		public void SetUnitDetailModelBackButtonOnClick(UnityAction onCreated);
		private void FriendGetSupportCharaDetailRequest();
		private void OnSuccess(FriendGetSupportCharaDetailResponse res);
	}
}
