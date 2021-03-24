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
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestCommonTableViewCell<T> : TableViewCell<T>
	{
		// Fields
		private static string returnSceneName;
		[SerializeField]
		public Button baseButton;
		public Image baseImage;
		public UnityEngine.UI.Text title;
		public UnityEngine.UI.Text description;
		protected int curQuestId;
		protected QuestStoryPopup storyPopup;
		[SerializeField]
		private Image _newMarkImage;
		private CanvasGroup _cellCanvasGroup;
		private Sprite baseImageDefaultSprite;
		private Material baseImageDefaultMaterial;
		private Vector2 baseImageDefaultSize;
		[CompilerGenerated]
		private T _cellData_k__BackingField;
	
		// Properties
		public Image newMarkImage { get; }
		public T cellData { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CanvasGroup cellCanvasGroup { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public PlayModeSelectDialog playModeSelectDialog;
			public UnityAction __9__0;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _ShowQuestPlayModeSelectDialog_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public Action onError;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _StartStoryQuestApi_b__0(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public Action onError;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _StartEventStoryQuestApi_b__0(ErrorType errorType, int resultCode);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c<T> __9;
			public static Action __9__34_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GotoStory_b__34_0();
		}
	
		// Constructors
		public QuestCommonTableViewCell();
		static QuestCommonTableViewCell();
	
		// Methods
		protected virtual void Start();
		public void SaveDefaultBaseImageAssets();
		protected void SetDefaultBaseImageAssets();
		public override void UpdateContent(T data);
		public virtual void OnClick();
		protected virtual void OnClickDetailPopupCancel();
		protected void OnClickDetailPopupOK(int questId);
		private void ShowQuestPlayModeSelectDialog(int questID);
		public static void StartStoryQuestApi(int questID, QuestGroupType groupType, string backSceneName = null, Action onError = null);
		public static void StartEventStoryQuestApi(int storyID, string backSceneName = null, Action onError = null);
		private static void OnSuccessReadStoryEvent(EventStoryReadResponse res);
		private static void OnSuccessQuestReadStoryMain(QuestReadStoryResponse res);
		private static void OnSuccessQuestReadStoryEvent(QuestReadStoryResponse res);
		public static void GotoStory(string scriptPath);
		protected void OnClickStoryPopupOK(int questId, QuestGroupType groupType);
		protected void OnClickStoryPopupCancel();
		public virtual void OnQuestPlayModeSoloSelected(int questId);
	}
}
