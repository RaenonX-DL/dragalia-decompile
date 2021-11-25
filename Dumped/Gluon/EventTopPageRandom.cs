using UnityEngine;

namespace Gluon
{
	public class EventTopPageRandom : EventTopPageBase
	{
		[SerializeField]
		[Header("TreasureTime")]
		private TreasureTimeController treasureTimeCtrl;

		protected override void Awake()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}
	}
}
