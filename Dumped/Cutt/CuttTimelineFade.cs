using UnityEngine;
using UnityEngine.UI;

namespace Cutt
{
	public class CuttTimelineFade
	{
		private CuttTimelineKeyFadeDataList _keys;

		private GameObject _canvas;

		private GameObject fadeObject;

		private Image image;

		private Sprite whiteSprite;

		public void Initialize(CuttTimelineKeyFadeDataList keys, CuttTimelineControl timelineControl, GameObject canvasObject, int siblingIndex = -1)
		{
		}

		public void Release()
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame)
		{
		}

		public void SetFadePanel(bool enableFlag)
		{
		}
	}
}
