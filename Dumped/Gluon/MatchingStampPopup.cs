using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class MatchingStampPopup : PopupBase
	{
		[SerializeField]
		[Header("component")]
		private PageViewBase pageView;

		[SerializeField]
		private ChatIconUI[] chatIcons;

		[SerializeField]
		[Header("parameter")]
		private float fadeTime;

		[SerializeField]
		private float stayTime;

		private int playerIndex;

		private UnityAction<int> onStampClicked;

		private bool isDisplayIcon;

		private const int iconPerPageCount = 8;

		private const string prefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingStampPopup";

		private const string pagePrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingStampPage";

		public static MatchingStampPopup Create()
		{
			return null;
		}

		public void EnableAndShow()
		{
		}

		public void Initialize(int playerIndex, [Optional] UnityAction<int> onStampClicked, bool isDisplayIcon = true)
		{
		}

		public void SetStampParent(Transform[] parents)
		{
		}

		private void OnClickIcon(int id)
		{
		}

		public void DisplayIcon(int playerIndex, int id, bool callbakFlag = true)
		{
		}

		public void SetPlayerNo(int no)
		{
		}
	}
}
