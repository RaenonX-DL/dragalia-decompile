using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallGetRewardPopup : CommonPopup
	{
		[SerializeField]
		private Text questWallGetRewardLevel;

		[SerializeField]
		private Image questWallGetRewardLogoImage;

		[SerializeField]
		private Image questWallGetRewardTotalLevelImage;

		[SerializeField]
		private GameObject questWallGetRewardNode;

		[SerializeField]
		private GameObject questWallGetRewardCell;

		public static QuestWallGetRewardPopup Create(int groupId, [Optional] UnityAction OnCloseCallback)
		{
			return null;
		}

		public void InitContents(int groupId)
		{
		}

		public void SetContents(int groupId)
		{
		}
	}
}
