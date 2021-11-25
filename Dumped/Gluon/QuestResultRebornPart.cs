using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class QuestResultRebornPart : MonoBehaviour
	{
		public QuestResultRebornHeartAnimation[] rebornHeartAnimations;

		public float heartAnimationInterval;

		public GameObject infinityImage;

		private const string prefabPath = "Prefabs/OutGame/QuestResult/QuestResultRebornPart";

		public static QuestResultRebornPart Create(Transform parent, out Sequence rebornHeartAnimations)
		{
			return null;
		}

		private void InitWithSequence(out Sequence sequenceHeartAnim)
		{
		}
	}
}
