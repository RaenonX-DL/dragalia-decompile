using UnityEngine;

namespace Gluon
{
	public class QuestCloudController : MonoBehaviour
	{
		[SerializeField]
		private QuestCloud[] questCloudList;

		[SerializeField]
		private bool isSetCustomRenderQueue;

		[SerializeField]
		private int customRenderQueueValue;

		private bool _isPlay;

		private float targetMaxPosY;

		private float targetMinPosY;

		private float targetLeftPosX;

		private float targetRightPosX;

		private bool isTargetInfo;

		public QuestCloud[] QuestCloudList => null;

		public bool isPlay => default(bool);

		private void Start()
		{
		}

		public void PlayCloud(Vector2 worldMapSize)
		{
		}

		public void IsCloud(bool enable)
		{
		}

		public void IsShadow(bool enable)
		{
		}

		public void SetTargetRange(float max, float min, float left = 0f, float right = 0f)
		{
		}

		private void Update()
		{
		}

		private void chcekCloudCover()
		{
		}
	}
}
