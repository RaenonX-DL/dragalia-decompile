using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CollectEventGiftRewardPopup : PopupBase
	{
		[SerializeField]
		private Transform iconParent;

		private List<CommonIcon> iconList;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text commentText;

		public static CollectEventGiftRewardPopup Create(UnityAction onClose)
		{
			return null;
		}

		public void SetupEventStoryReward()
		{
		}

		private CommonIcon CreateIcon(AtgenBuildEventRewardEntityList reward)
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}
	}
}
