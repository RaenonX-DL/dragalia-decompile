using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FortMenuUICanvas : AnimationUICanvas
	{
		public FortMenuScene scene;

		public Button menuButton;

		public Button itemButton;

		public Button fortButton;

		public Button knightsStoryButton;

		public Button dragonStoryButton;

		public Button dragonContactButton;

		public Button castleStoryButton;

		public Text talkName;

		public Text talkText;

		public GameObject balloon;

		[SerializeField]
		private GameObject upgradeableText;

		public GameObject fortBadge;

		public Badge charaStoryBadge;

		public Badge dragonStoryBadge;

		public Badge castleStoryBadge;

		public GameObject pettingBadge;

		public Text coinNumText;

		private void Start()
		{
		}

		public void OnFortButtonPressed()
		{
		}

		public void OnKnightsStoryButtonPressed()
		{
		}

		public void OnDragonStoryButtonPressed()
		{
		}

		public void OnCastleStoryButtonPressed()
		{
		}

		public void OnDragonContactButtonPressed()
		{
		}

		public void SetTalkTextString(string text)
		{
		}

		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false)
		{
		}

		public void DisableAllButtonExceptFort()
		{
		}

		public void DisableAllButtonExceptDragonContact()
		{
		}

		public void TutorialButtonSetting(bool isNowTutorial)
		{
		}

		public void UpdateCoinText()
		{
		}

		public void ShowUpgradeableText(bool show)
		{
		}
	}
}
