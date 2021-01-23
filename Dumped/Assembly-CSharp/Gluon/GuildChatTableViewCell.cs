/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildChatTableViewCell : TableViewCell<Gluon.GuildChatModel.ChatTableViewData>
	{
		// Fields
		[Header]
		[SerializeField]
		public RectTransform cellFrame;
		[Header]
		[SerializeField]
		private GameObject[] panels;
		[Header]
		[SerializeField]
		private CommonIcon[] icons;
		[SerializeField]
		private UnityEngine.UI.Text[] nameTexts;
		[SerializeField]
		private UnityEngine.UI.Text[] timeTexts;
		[SerializeField]
		private UnityEngine.UI.Text[] normalTexts;
		[SerializeField]
		private CommonIcon[] stamps;
		[Header]
		[SerializeField]
		private GameObject[] normalFrames;
		[SerializeField]
		private GameObject[] stampFrames;
		[Header]
		[SerializeField]
		private GameObject dateChangeObject;
		[SerializeField]
		private UnityEngine.UI.Text dateChangeText;
		[Header]
		[SerializeField]
		private LayoutElement[] textWrapLayoutElements;
		[Header]
		[SerializeField]
		public Animator[] animators;
		[SerializeField]
		private GuildChatAnimationSupport[] animationSupporters;
		[Header]
		[SerializeField]
		private PointerEventHandler[] pointerEventHandlers;
		[Header]
		[SerializeField]
		private GameObject reportButtonGroup;
		[Header]
		[SerializeField]
		private LayoutElement sizeKeeper;
		private const float textBoxMaxWidth = 400f;
		private const int othersPanelNum = 0;
		private const int ownPanelNum = 1;
		private const int textOnlyPanelNum = 2;
		private int panelNum;
		private const int maxRetryTime = 4;
	
		// Properties
		private GameObject panel { get; }
		private CommonIcon icon { get; }
		private UnityEngine.UI.Text nameText { get; }
		private UnityEngine.UI.Text timeText { get; }
		private UnityEngine.UI.Text normalText { get; }
		private CommonIcon stamp { get; }
		private GameObject normalFrame { get; }
		private GameObject stampFrame { get; }
		private LayoutElement textWrapLayoutElement { get; }
		private Animator animator { get; }
		private GuildChatAnimationSupport animationSuppoter { get; }
		private PointerEventHandler pointerEventHandler { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public GuildChatTableViewCell __4__this;
			public GuildChatModel.ChatTableViewData data;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal void _SetLongPressReportButton_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0
		{
			// Fields
			public string text;
	
			// Constructors
			public __c__DisplayClass69_0();
	
			// Methods
			internal void _SetSpeechButton_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0
		{
			// Fields
			public GuildChatTableViewCell __4__this;
			public GuildChatModel.ChatTableViewData data;
	
			// Constructors
			public __c__DisplayClass70_0();
	
			// Methods
			internal void _SetJoinButton_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0
		{
			// Fields
			public GuildChatModel.ChatTableViewData data;
			public GuildChatTableViewCell __4__this;
	
			// Constructors
			public __c__DisplayClass74_0();
	
			// Methods
			internal void _OnJoinButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0
		{
			// Fields
			public MatchingGetRoomNameResponse res;
	
			// Constructors
			public __c__DisplayClass75_0();
	
			// Methods
			internal void _OnMatchingGetRoomNameSuccess_b__0(bool isRecoveredStamina);
		}
	
		// Constructors
		public GuildChatTableViewCell();
	
		// Methods
		private void Update();
		public override void UpdateContent(GuildChatModel.ChatTableViewData data);
		public void UpdateContent(GuildChatModel.ChatTableViewData data, bool isForceRebuild);
		private void SelectIconPanel(bool isMine);
		private void SelectTextOnlyPanel();
		private void SetPanel();
		private void SetIcon(GuildModel.ProfileIconData iconData);
		private void SetName(string name);
		private void SetText(string text);
		private void SetStamp(int stampId);
		private void SetTime(DateTime time);
		private void SetFrame(GuildChatModel.ContentType contentType);
		private void SetDataChangeObject(bool isDateCHange, DateTime time);
		private void SetReportButtonObject(bool isReportState);
		private void SetMainContent(GuildChatModel.ChatTableViewData data);
		private void SetSystemMessage(GuildChatModel.ChatTableViewData data);
		private void SetMultiLink(GuildChatModel.ChatTableViewData data);
		private string GetMultiplayLinkText(bool isFull, int nemberCount, int questId);
		private void SetTextAreaSize();
		public GuildChatModel.ChatTableViewData GetData();
		private void ClearPointerEvent();
		private void SetLongPressReportButton(GuildChatModel.ChatTableViewData data);
		private void SetSpeechButton(string text);
		private void SetJoinButton(GuildChatModel.ChatTableViewData data);
		private void OnLongPressReportButtonPressed(GuildChatModel.ChatTableViewData data);
		public void OnReportButtonPressed();
		public void OnReportCancelButtonPressed();
		private void OnJoinButtonPressed(GuildChatModel.ChatTableViewData data);
		private void OnMatchingGetRoomNameSuccess(MatchingGetRoomNameResponse res);
		private void OnMatchingGetRoomNameError(ErrorType errorType, int resultCode);
		private void SetAnimationWaitState(GuildChatModel.ChatTableViewData data);
		private void KeepCellSize(GuildChatModel.ChatAnimationWaitMode animationWaitState, Vector2 size);
		public void OnStampClick();
		private void PlayStampVoice(int stampId);
	}
}
