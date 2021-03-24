/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FriendSearchView : FriendPanelBase
	{
		// Fields
		private static Action onHttpDone;
		public Transform frameParent;
		public RectTransform referenceRect;
		private ModeTab currentMode;
		[SerializeField]
		private UnityEngine.UI.Text friendNumText;
		[SerializeField]
		private GameObject searchViewArea;
		[SerializeField]
		private InputField inputIdField;
		[SerializeField]
		private UnityEngine.UI.Text inputIdPlaceholder;
		[SerializeField]
		private UnityEngine.UI.Text yourIdCaptionText;
		[SerializeField]
		private UnityEngine.UI.Text yourIdText;
		[SerializeField]
		private UnityEngine.UI.Text infoText;
		[SerializeField]
		private Button searchButton;
		[SerializeField]
		private FriendListController listController;
		[SerializeField]
		private GameObject idTabOnImage;
		[SerializeField]
		private GameObject recommendTabOnImage;
		private List<FriendListCellData> cellDataList;
	
		// Nested types
		private enum ModeTab
		{
			Id = 0,
			Recommended = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<UserSupportList, ulong> __9__20_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal ulong _SetRecommendedList_b__20_0(UserSupportList e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public FriendSearchView __4__this;
			public FriendListCellData data;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _RequestFriendRequest_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public UnityAction successCallBack;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _RequestFriendRequest_b__0(FriendRequestResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _OnCopyButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public FriendSearchView __4__this;
			public FriendSearchResultPopup popup;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _OnSuccessFriendSearch_b__0();
		}
	
		// Constructors
		public FriendSearchView();
	
		// Methods
		public static FriendSearchView Create(Transform parent, FriendScene scene);
		private void Start();
		private void SetMode(int index);
		private void SetRecommendedList();
		private void RequestFriendRequest(FriendListCellData data);
		private void RequestFriendRequest(ulong friendId, UnityAction successCallBack = null);
		public void OnCopyButtonPressed();
		public void OnSearchButtonPressed();
		private void RequestFriendSearch(ulong id);
		private void OnSuccessFriendSearch();
		private void OnErrorUnsuitableId();
		public void OnSortButtonPressed();
		public void OnIdSearchButtonPressed();
		public void OnRecommendListButtonPressed();
		public static void RequestForEntryHttp(Action onHttpDoneCallback);
		public static void OnEntryHttpSuccess();
		[CompilerGenerated]
		private void _Start_b__18_0(string text);
		[CompilerGenerated]
		private void _RequestFriendSearch_b__25_0(FriendIdSearchResponse res);
	}
}
