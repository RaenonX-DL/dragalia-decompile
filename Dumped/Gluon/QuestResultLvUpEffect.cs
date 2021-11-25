using UnityEngine;

namespace Gluon
{
	public class QuestResultLvUpEffect : MonoBehaviour
	{
		[SerializeField]
		public TweenSequenceVisualizer[] sequences;

		[ContextMenu("Play")]
		public void Play()
		{
		}
	}
}
