using UnityEngine;

namespace Gluon
{
	public class BRPulsePoint : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("é\u0085\u008dç½®æ\u00b8\u0088ã\u0081¿ã\u0081®BRPulse")]
		private BRPulse pulse;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å\u0088\u009dã\u0081®å\u008d\u008aå¾\u0084")]
		public float radius;

		[SerializeField]
		[Tooltip("ç\u00b4\u0090ã\u0081¥ã\u0081\u008fã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼é\u0085\u008dç½®ã\u0081®é\u009b£æ\u0098\u0093åº¦")]
		private DungeonManager.eStageDifficulty stageDifficulty;

		public DungeonManager.eStageDifficulty StageDifficulty => default(DungeonManager.eStageDifficulty);

		private void Awake()
		{
		}
	}
}
