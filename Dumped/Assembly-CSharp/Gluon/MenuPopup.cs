/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MenuPopup : CommonPopup, ICustomMessage
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text[] contentsText;
		[SerializeField]
		private Badge inquireBadge;
		private const string prefsKeyLastOpenComicEpisordNumKey = "LastOpenComicEpisordNum";
		[SerializeField]
		private Badge friendBadge;
		[SerializeField]
		private Badge shopBadge;
		[SerializeField]
		private Button guildButton;
		[SerializeField]
		private GameObject guildBadge;
		[SerializeField]
		private GameObject guildInviteBadge;
		[SerializeField]
		private UnityEngine.UI.Text comicBalloonText;
		[SerializeField]
		private UnityEngine.UI.Text helpComicBalloonText;
		[SerializeField]
		private PointerEventHandler comicButton;
		[SerializeField]
		private TweenSequenceVisualizer animBalloonButtonPressed;
		[SerializeField]
		private TweenSequenceVisualizer animBalloonDefault;
		public static UnityAction<UnityAction> changeSceneCallback;
		private Footer.MenuTab tempCurrentMenuTab;
	
		// Nested types
		private enum MenuContents
		{
			None = -1,
			Item = 0,
			PlayerInfo = 1,
			Friend = 2,
			Help = 3,
			Option = 4,
			Other = 5,
			Shop = 6,
			Guild = 7,
			Comic = 8,
			HelpComic = 9,
			AdvStory = 10,
			Max = 11
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__16_0;
			public static UnityAction __9__19_2;
			public static UnityAction __9__19_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Create_b__16_0();
			internal void _InitSetting_b__19_2();
			internal void _InitSetting_b__19_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _InitSetting_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public UnityAction loadSceneCallback;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _IrregularLoadScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _RequestCartoonLatest_b__0(CartoonLatestResponse res);
		}
	
		// Constructors
		public MenuPopup();
		static MenuPopup();
	
		// Methods
		public static MenuPopup Create();
		protected override void OnDestroy();
		private void OnDisable();
		private void InitSetting();
		private void MenuContentsButtonPressed(int contentsIndex);
		public static void IrregularLoadScene(UnityAction loadSceneCallback);
		private static void PrepareLoadScene();
		private void RequestCartoonLatest(UnityAction successCallback);
		private void OnError(ErrorType errorType, int resultCode);
		private int GetComicNum();
		private string GetMenuContentsText(MenuContents content);
		public void UpdateBadge(bool hasNew);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public static bool IsShowShopBadge();
		public static bool IsShowMenuBadge();
		[CompilerGenerated]
		private void _InitSetting_b__19_0(PointerEventData eventData);
		[CompilerGenerated]
		private void _MenuContentsButtonPressed_b__20_0();
		[CompilerGenerated]
		private void _MenuContentsButtonPressed_b__20_1(OptionPopup popup);
		[CompilerGenerated]
		private void _MenuContentsButtonPressed_b__20_2();
		[CompilerGenerated]
		private void _MenuContentsButtonPressed_b__20_6();
		[CompilerGenerated]
		private void _MenuContentsButtonPressed_b__20_3();
		[CompilerGenerated]
		private void _MenuContentsButtonPressed_b__20_4();
		[CompilerGenerated]
		private void _MenuContentsButtonPressed_b__20_5();
	}
}
