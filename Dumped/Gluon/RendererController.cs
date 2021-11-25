using UnityEngine;

namespace Gluon
{
	[ExecuteAlways]
	public class RendererController : MonoBehaviour
	{
		[SerializeField]
		private int _minorSortingOrder;

		private Renderer _renderer;

		private int _majorSortingOrder;

		private int _sortingScale;

		private int _sortingOtherOffset;

		private void UpdateRenderer()
		{
		}

		public void SetSortingOrder(int sortingOrder, int sortingScale, int sortingOtherOffset, bool isSetFinal)
		{
		}

		public void SetMinorSortingOrder(int sortingOrder)
		{
		}

		private void Start()
		{
		}
	}
}
