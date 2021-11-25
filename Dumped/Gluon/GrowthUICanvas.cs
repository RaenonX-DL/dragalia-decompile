using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthUICanvas : AnimationUICanvas
	{
		public GrowthScene scene;

		public Button menuButton;

		public Button itemButton;

		public Button growthCharacterButton;

		public Button growthManaCircleButton;

		public Button growthWeaponButton;

		public Button growthDragonButton;

		public Button growthAmuletButton;

		public GameObject balloon;

		public GameObject growthCharacterMaintenance;

		public GameObject growthManaCircleMaintenance;

		public GameObject growthWeaponMaintenance;

		public GameObject growthDragonMaintenance;

		public GameObject growthAmuletMaintenance;

		public Text manaNumText;

		public Text awakeningNumText;

		public Text rupiNumText;

		public Text talkName;

		public Text talkText;

		public Badge weaponBadgeIcon;

		public Badge crestBadgeIcon;

		private void Start()
		{
		}

		public void OnGrowthCharacterButtonPressed()
		{
		}

		public void OnGrowthManaCircleButtonPressed()
		{
		}

		public void OnGrowthDragonButtonPressed()
		{
		}

		public void OnGrowthWeaponButtonPressed()
		{
		}

		public void OnGrowthAmuletButtonPressed()
		{
		}

		public void OnGrowthCraftButtonPressed()
		{
		}

		public void SetTalkTextString(string text)
		{
		}

		public void SetTalkNameString(string text)
		{
		}

		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false)
		{
		}

		public void CheckTutorialLockButton(bool isIgnorePressed = false)
		{
		}

		public void DisableAllButtonExceptGrowthAmulet()
		{
		}

		public void DisableAllButtonExceptManaCircle()
		{
		}

		public void DisableAllButtonExceptCraft()
		{
		}

		public void CheckMaintenance()
		{
		}

		public void UpdateFundsTexts()
		{
		}

		public void UpdateBadge()
		{
		}
	}
}
