using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestCommonTableViewCell<T> : TableViewCell<T>
	{
		private static string returnSceneName;

		[SerializeField]
		public Button baseButton;

		public Image baseImage;

		public Text title;

		public Text description;

		protected int curQuestId;

		protected QuestStoryPopup storyPopup;

		[SerializeField]
		private Image _newMarkImage;

		private CanvasGroup _cellCanvasGroup;

		private Sprite baseImageDefaultSprite;

		private Material baseImageDefaultMaterial;

		private Vector2 baseImageDefaultSize;

		public Image newMarkImage => null;

		public T cellData
		{
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CanvasGroup cellCanvasGroup
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		protected virtual void Start()
		{
		}

		public void SaveDefaultBaseImageAssets()
		{
		}

		protected void SetDefaultBaseImageAssets()
		{
		}

		public override void UpdateContent(T data)
		{
		}

		public virtual void OnClick()
		{
		}

		protected virtual void OnClickDetailPopupCancel()
		{
		}

		protected void OnClickDetailPopupOK(int questId)
		{
		}

		private void ShowQuestPlayModeSelectDialog(int questID)
		{
		}

		public static void StartStoryQuestApi(int questID, QuestGroupType groupType, [Optional] string backSceneName, [Optional] Action onError)
		{
		}

		public static void StartStoryQuest(int storyID, [Optional] string backSceneName)
		{
		}

		public static void StartEventStoryQuestApi(int storyID, [Optional] string backSceneName, [Optional] Action onError)
		{
		}

		private static void OnSuccessReadStoryEvent(EventStoryReadResponse res)
		{
		}

		private static void OnSuccessQuestReadStoryMain(QuestReadStoryResponse res)
		{
		}

		private static void OnSuccessQuestReadStoryEvent(QuestReadStoryResponse res)
		{
		}

		public static void GotoStory(string scriptPath)
		{
		}

		protected void OnClickStoryPopupOK(int questId, QuestGroupType groupType)
		{
		}

		protected void OnClickStoryPopupCancel()
		{
		}

		public virtual void OnQuestPlayModeSoloSelected(int questId)
		{
		}
	}
}
