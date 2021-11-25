using System.Runtime.InteropServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallTotalRewardPopup : CommonPopup
	{
		[SerializeField]
		private Image questWallBg;

		[SerializeField]
		private Image[] totallevel;

		[SerializeField]
		private GameObject totalLvRewardNode;

		[SerializeField]
		private GameObject totalLvRewardCell;

		[SerializeField]
		private GameObject totalLvRewardPikupNode;

		[SerializeField]
		private GameObject totalLvRewardPikupCell;

		[SerializeField]
		private Text[] elementLvText;

		[SerializeField]
		private GameObject nextPickupParent;

		[SerializeField]
		private CommonIcon nextPickupCommonIcon;

		[SerializeField]
		private GameObject nextPickup;

		[SerializeField]
		private GameObject nothingGetTime;

		private int groupId;

		public static QuestWallTotalRewardPopup Create(int groupId, [Optional] UnityAction OnCloseCallback)
		{
			return null;
		}

		public void SetContent()
		{
		}

		private void SetSumImage(int sumLevel)
		{
		}

		private void SetLevelImage(Image image, int level)
		{
		}

		private void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void SetLevel(int[] list)
		{
		}
	}
}
