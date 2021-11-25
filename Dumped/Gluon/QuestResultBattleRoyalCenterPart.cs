using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultBattleRoyalCenterPart : MonoBehaviour
	{
		[SerializeField]
		[Header("Content")]
		public Text killCountText;

		public Text assistCountText;

		public Transform flashPos;

		private const string prefabPath = "Prefabs/OutGame/QuestResult/QuestResultBattleRoyalCenterPart";

		public static QuestResultBattleRoyalCenterPart Create(Transform parent)
		{
			return null;
		}

		private void Start()
		{
		}
	}
}
