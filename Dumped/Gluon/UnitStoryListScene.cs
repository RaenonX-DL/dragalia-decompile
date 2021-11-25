using System.Collections;
using System.Collections.Generic;
using Cute.AssetBundle;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class UnitStoryListScene : SceneBase
	{
		public enum SelectState
		{
			None = -1,
			CharaUnreadStory = 0,
			CharaAllStory = 1,
			CharaAllGroup = 2,
			DragonUnreadStory = 3,
			DragonAllStory = 4,
			CastleStoryUnreadStory = 5,
			CastleStoryAllStory = 6,
			Max = 7,
			SampleStory = 0
		}

		public enum TypeTab
		{
			None = -1,
			Chara,
			Dragon,
			Castle,
			Max,
			Sample
		}

		public enum ReadTab
		{
			Unread,
			All,
			Max
		}

		private struct SampleStoryInfo
		{
			public UnitStoryElement storyData;

			public UnitStoryGroupElement groupData;

			public CharaDataElement charaData;

			public AtgenUnitList summonChara;

			public bool isPickup;
		}

		public static SelectState selectState;

		public static TypeTab currentTypeTab;

		public static ReadTab currentReadTab;

		public static int selectGroupId;

		public static int autoScrollStoryId;

		public static bool isFromEventScene;

		public Camera mainCamera;

		public static bool isStoryReadConnected;

		public static int summonId;

		public static bool isBackToSummonShop;

		public static SummonType summonType;

		public static int summonGroupId;

		public static SummonTopItemView.SummonTopItemTabType lastSelectedSummonType;

		private SimpleAnimationButton _backButtonAnim;

		private ButtonPressedMark _backButtonMark;

		private UnitStoryListCanvas mainCanvas;

		private int[] unreadCount;

		private UnitStoryListController[] controllerList;

		private List<UnitStoryListCellData>[] cellDataList;

		private List<SampleStoryInfo> sampleStoryInfos;

		private string showedNewCastleStoryString;

		public static string prefabDir;

		public const int triggerItemId = 201008001;

		private const string prefsKeyShowedNewCastleStoryKey = "ShowedNewCastleStory";

		private string sampleBannerRootPath;

		private string defaultSampleBannerName;

		private SimpleAnimationButton BackButtonAnim => null;

		private ButtonPressedMark BackButtonMark => null;

		public static bool IsUnreadStory(TypeTab type)
		{
			return default(bool);
		}

		public static bool IsOpenCastleStory(bool withStepCheck = true)
		{
			return default(bool);
		}

		public static bool IsOverCurrentTimeByDateString(string dateStr)
		{
			return default(bool);
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void SetEnableBackButtonExitAnimation(bool enable)
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private IEnumerator LoadListData()
		{
			return null;
		}

		public void SetType(int tabIndex)
		{
		}

		public void SetRead(int tabIndex)
		{
		}

		private void SetUnitStoryList(TypeTab type, ReadTab read, int groupId = -1)
		{
		}

		private void SetUnitStoryList(SelectState state, bool isRecreate = true)
		{
		}

		private void LoadListDataSample()
		{
		}

		public void OnBackButtonPressed()
		{
		}

		public void CreateSortPopup()
		{
		}

		public static void OnError(ErrorType errorType, int resultCode)
		{
		}

		public void OnButtonPressedStory(TypeTab type, int storyId, bool needRequest)
		{
		}

		public static void RequestUpdateRead(int storyId, TypeTab type, UnityAction successCallback)
		{
		}

		private List<UnitStoryListCellData> SortCellDataListForUnitStory(List<UnitStoryListCellData> list, SelectState state)
		{
			return null;
		}

		private void SetCaption()
		{
		}

		private UnitStoryElement GetNextStory(UnitStoryElement readedStory)
		{
			return null;
		}

		private void CreateReadNextStoryConfirmPopup(UnitStoryElement nextStory, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice)
		{
		}

		private void CreateStoryList()
		{
		}

		private List<UnitStoryListCellData> CreateSampleStoryList()
		{
			return null;
		}

		private List<SampleStoryInfo> GetSampleStoryInfoList(OddsUnitDetail[] summonCharas)
		{
			return null;
		}

		private bool TryGetSampleStoryInfo(AtgenUnitList summonChara, bool isPickup, out SampleStoryInfo sampleStoryInfo)
		{
			return default(bool);
		}

		public override void OnPresentReceived()
		{
		}

		public static string[] GetShowedNewCastleStoryList()
		{
			return null;
		}

		private void CreateCharaAllStoryListByGroupId(int groupId)
		{
		}

		public override void StartExitAnimation()
		{
		}

		protected override void OnExitAnimationCompleted()
		{
		}
	}
}
