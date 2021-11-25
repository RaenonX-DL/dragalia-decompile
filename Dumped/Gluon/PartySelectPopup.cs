using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartySelectPopup : PopupBase
	{
		[SerializeField]
		private PartySelectPopupCell[] cells;

		public Image partyGroupIcon;

		public Sprite[] partyGroupSprites;

		public Text partyNameText;

		[SerializeField]
		private Image partyPowerBgImage;

		[SerializeField]
		private Image raidPartyPowerBgImage;

		[SerializeField]
		private Text powerText;

		[SerializeField]
		private GameObject pagerParent;

		[SerializeField]
		private float pagerWidth;

		[SerializeField]
		private GameObject editSkillPanel;

		private int selectPartyNo;

		private int selectPartyGroup;

		private bool isSixteenRandomMatching;

		private bool isRaidBoostOn;

		private bool showFullPartyPower;

		private List<PartyPager> pagers;

		private UnityAction onPartyChanged;

		private const string popupPrefabPath = "Prefabs/OutGame/QuestSupportSelect/Popup/PartySelectPopup";

		private const string raidPopupPrefabPath = "Prefabs/OutGame/QuestSupportSelect/Popup/RaidPartySelectPopup";

		public static PartySelectPopup Create(bool useRaidPartySelectPopup, bool isSixteenRandomMatching, bool isRaidBoostOn, bool showFullPartyPower, UnityAction onPartyChanged)
		{
			return null;
		}

		private void Initialize(bool isSixteenRandomMatching, bool isRaidBoostOn, bool showFullPartyPower, UnityAction onPartyChanged)
		{
		}

		private void UpdatePartyData()
		{
		}

		public void OnOk()
		{
		}

		public void OnCloseButton()
		{
		}

		private void OnPagerPressed(int pressedPagerIndex)
		{
		}

		public void OnPartyChangeButtonPressed()
		{
		}

		public void OnArrowPressed(int increment)
		{
		}

		private void ReloadPager()
		{
		}
	}
}
