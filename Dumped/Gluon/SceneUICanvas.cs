using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class SceneUICanvas : MonoBehaviour
	{
		private enum UiCameraParentScene
		{
			None,
			QuestSelect
		}

		private const int additiveSceneUiSortingOrderDefault = 80;

		private const int additiveSceneUiSortingOrderOverHeader = 120;

		[SerializeField]
		private string parentSceneName;

		[SerializeField]
		private bool isOverHeader;

		[SerializeField]
		private GameObject addtiveSceneObj;

		[SerializeField]
		[Header("Uiã\u0082«ã\u0083¡ã\u0083©è\u00a8­å®\u009a")]
		private UiCameraParentScene uiCameraParentScene;

		private Camera mainSceneUiCamera;

		public void OnSceneUICanvasLoaded([Optional] Camera additiveSceneCamera)
		{
		}

		private Camera GetMainSceneUiCamera(UiCameraParentScene uiCameraParentScene)
		{
			return null;
		}

		private Camera GetQuestSelectUiCamera()
		{
			return null;
		}

		public T GetSceneComponent<T>(string sceneName)
		{
			return (T)null;
		}
	}
}
