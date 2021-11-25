using UnityEngine;

namespace Gluon
{
	public class DollFieldUniqueCtrl : EnemyUniqueCtrl
	{
		private const string effKey = "effkey_DollField";

		private float _timer;

		private bool _hasPlayEff;

		public override void FastUpdate()
		{
		}

		public void PlayEffect(string effName, float duration, Vector2 center, float scale, string seName)
		{
		}
	}
}
