using UnityEngine;

namespace Gluon
{
	public class EventTopPageExHunter : EventTopPageBase
	{
		[SerializeField]
		[Header("TalkWindow")]
		public EventTalkWindowModule talkWindowModule;

		[SerializeField]
		[Header("New")]
		public GameObject newObject;

		public override void OnPageBecomeActive(object data)
		{
		}

		public void OnTradeButtonPressed()
		{
		}
	}
}
