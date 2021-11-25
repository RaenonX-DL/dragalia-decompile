using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class FriendSearchView : FriendPanelBase
	{
		private enum ModeTab
		{
			Id,
			Recommended
		}

		private static Action onHttpDone;

		public Transform frameParent;

		public RectTransform referenceRect;

		private ModeTab currentMode;

		[SerializeField]
		private Text friendNumText;

		[SerializeField]
		private GameObject searchViewArea;

		[SerializeField]
		private InputField inputIdField;

		[SerializeField]
		private Text inputIdPlaceholder;

		[SerializeField]
		private Text yourIdCaptionText;

		[SerializeField]
		private Text yourIdText;

		[SerializeField]
		private Text infoText;

		[SerializeField]
		private Button searchButton;

		[SerializeField]
		private FriendListController listController;

		[SerializeField]
		private GameObject idTabOnImage;

		[SerializeField]
		private GameObject recommendTabOnImage;

		private List<FriendListCellData> cellDataList;

		public static FriendSearchView Create(Transform parent, FriendScene scene)
		{
			return null;
		}

		private void Start()
		{
		}

		private void SetMode(int index)
		{
		}

		private void SetRecommendedList()
		{
		}

		private void RequestFriendRequest(FriendListCellData data)
		{
		}

		private void RequestFriendRequest(ulong friendId, [Optional] UnityAction successCallBack)
		{
		}

		public void OnCopyButtonPressed()
		{
		}

		public void OnSearchButtonPressed()
		{
		}

		private void RequestFriendSearch(ulong id)
		{
		}

		private void OnSuccessFriendSearch()
		{
		}

		private void OnErrorUnsuitableId()
		{
		}

		public void OnSortButtonPressed()
		{
		}

		public void OnIdSearchButtonPressed()
		{
		}

		public void OnRecommendListButtonPressed()
		{
		}

		public static void RequestForEntryHttp(Action onHttpDoneCallback)
		{
		}

		public static void OnEntryHttpSuccess()
		{
		}
	}
}
