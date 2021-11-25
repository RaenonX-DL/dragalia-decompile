using Cutt;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon
{
	public class CuttFlashController : MonoBehaviour
	{
		[HideInInspector]
		public CuttFlashInitializeData initializeData;

		private FlRoot flRoot;

		private float scaleFactor;

		private RectTransform canvasRect;

		private CameraGroup flCameraGroup;

		private const float raidBossFlashSidebarWidthFull = 600f;

		private const float raidBossFlashSidebarChangeBorder = 200f;

		private const float raidBossFlashSidebarOffsetFirst = 200f;

		private const float raidBossFlashSidebarPixelToUnit = 100f;

		private const float raidBossEmptyDifficultTextOffsetY = -24f;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void PlayMotion(string labelName)
		{
		}

		public void AltherUpdate(int frame)
		{
		}

		public void SetFtuInitializeData(CuttFtuInitializeData data, string folderPath)
		{
		}

		private float GetTextWidth(TextMesh textMesh)
		{
			return default(float);
		}
	}
}
