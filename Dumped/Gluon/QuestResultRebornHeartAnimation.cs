using DG.Tweening;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon
{
	public class QuestResultRebornHeartAnimation : MonoBehaviour
	{
		[SerializeField]
		public Transform node;

		public GameObject offIcon;

		private FlRoot root;

		private const string prefabPath = "Prefabs/OutGame/QuestResult/pf_QuestResultRebornLifeIcon";

		private void Awake()
		{
		}

		public void Hide()
		{
		}

		public void HeartGray()
		{
		}

		public Sequence HeartIn(float delay)
		{
			return null;
		}
	}
}
