using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class DmodePopupCanvas : MonoBehaviour
	{
		private static List<GameObject> popupCanvasList;

		private static TapEffectCanvas tapEffectCanvas;

		private static string tapEffectCanvasPrefabPath;

		public static void DestroyPopupOnUnloadInGame()
		{
		}

		public static void SetPopupMode(bool v)
		{
		}

		public static bool IsPopupMode()
		{
			return default(bool);
		}

		public static PopupBase CreatePopup(string path, bool showStartAnimation)
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
