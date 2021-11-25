using UnityEngine;

namespace Gluon
{
	public class FlashPlayerManager : MonoBehaviour
	{
		[SerializeField]
		[Header("Flashå\u0090\u008cæ\u0099\u0082å\u0086\u008dç\u0094\u009fæ\u0095°ä\u00b8\u008aé\u0099\u0090")]
		private int flashPlayingMax;

		private PoolableObject<FlashPlayer> flashPlayerPool;

		public FlashPlayer GetflashPlayer()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void InitFlashPlayerPool()
		{
		}

		private FlashPlayer GetFlashPlayerFromPool()
		{
			return null;
		}
	}
}
