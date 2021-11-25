using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyPager : CommonPager
	{
		private const string prefabPath = "Prefabs/OutGame/Party/Party/PartyPager";

		[SerializeField]
		private Toggle toggle;

		[SerializeField]
		private Image onElementalImage;

		[SerializeField]
		private Image offElementalImage;

		[SerializeField]
		private Image onNoLeaderImage;

		[SerializeField]
		private Image offNoLeaderImage;

		[SerializeField]
		private Text noLeaderPageText;

		[SerializeField]
		private Image onCheckImage;

		public static GameObject GetPrefab()
		{
			return null;
		}

		public override void SetOn(bool on)
		{
		}

		public void SetElementalImage(ElementalType type)
		{
		}

		public override void SetIndex(int pageIndex)
		{
		}

		public void SetToggleInteractable(bool isEnable)
		{
		}

		public static void CreatePager(GameObject pagerParent, List<PartyPager> pagers, int pageCount, float pagerWidth, UnityAction<int> onPagerPressed, int startPartyIndex = -1)
		{
		}

		public static void UpdatePagerElementImage(List<PartyPager> pagers, int pageIndex, int startPartyIndex)
		{
		}

		public static void UpdatePager(GameObject pagerParent, List<PartyPager> pagers, int selectIndex)
		{
		}

		public static void ChangeParty(int index, UnityAction onSuccess)
		{
		}

		private static void CheckTemporaryCharaInParty(int oldCurrentPartyIndex)
		{
		}
	}
}
