using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactGiftRewardPopup : PopupBase
	{
		[SerializeField]
		private Transform iconParent;

		private List<CommonIcon> iconList;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text commentText;

		[SerializeField]
		private GameObject overText;

		public static ContactGiftRewardPopup Create(UnityAction onClose)
		{
			return null;
		}

		public void Setup()
		{
		}

		private CommonIcon CreateIcon(DragonRewardEntityList reward)
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}
	}
}
