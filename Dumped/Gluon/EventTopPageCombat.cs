using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventTopPageCombat : EventTopPageBase
	{
		[SerializeField]
		private GameObject combatMultiButton;

		[SerializeField]
		private GameObject combatQuestButtonMini;

		[SerializeField]
		private GameObject combatQuestButtonBig;

		[SerializeField]
		private Image rewardListButtonImage;

		[SerializeField]
		private Image rewardListButtonSelectImage;

		[SerializeField]
		private Sprite battleArenaRewardListButtonSprite;

		[SerializeField]
		private Sprite battleArenaRewardListButtonSelectSprite;

		protected override void Start()
		{
		}

		public override void OnQuestButtonTouched()
		{
		}

		protected override IEnumerator WaitForStatusInfoInitilizing(AnimationPattern pattern)
		{
			return null;
		}
	}
}
