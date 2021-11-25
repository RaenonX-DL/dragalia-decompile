using System.Collections;
using UnityEngine;

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
