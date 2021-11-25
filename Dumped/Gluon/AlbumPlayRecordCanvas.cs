using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumPlayRecordCanvas : MonoBehaviour
	{
		[SerializeField]
		private OutGameBgChara chara;

		[SerializeField]
		private RectTransform charaRectTransform;

		[SerializeField]
		private AnimationUITalkWindow balloon;

		[SerializeField]
		private AlbumCharaTalkSelector charaTalkSelector;

		[SerializeField]
		private Text talkName;

		[SerializeField]
		private Text talkText;

		public TabBase categoryTab;

		public Transform listParentTransform;

		public GameObject originCell;

		public RectTransform listFrameTransform;

		public DragEventScrollRect scrollRect;

		public DragEventScrollRect dummyContentsScrollRect;

		private AlbumPlayRecordListCategory listCategory;

		private List<AlbumPlayerRecordListCellData> recordDataList;

		private string charaVoiceGroupName;

		private bool isChangeScrollLayout;

		private void Start()
		{
		}

		private void LoadRecordData()
		{
		}

		private void ReloadList()
		{
		}

		public void OnCategoryTabPressed(int index)
		{
		}

		public void Talk(string charaVoiceGroupName, string voiceName)
		{
		}

		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false)
		{
		}

		public void SetTalkTextString(string text)
		{
		}

		public void SetTalkNameString(string text)
		{
		}

		public void SetChara()
		{
		}

		public void SetcharaVoiceGroupName(string charaVoiceGroupName)
		{
		}

		public void FirstVoiceStart()
		{
		}
	}
}
