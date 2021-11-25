using UnityEngine.EventSystems;

namespace Gluon
{
	public class StandaloneInputModuleCustom : StandaloneInputModule
	{
		public const int LAYER_UI = 5;

		public PointerEventData GetLastPointerEventDataPublic(int pinterId)
		{
			return null;
		}

		public bool IsUITouched(int pointerId)
		{
			return default(bool);
		}

		public int GetActivePointerId()
		{
			return default(int);
		}
	}
}
