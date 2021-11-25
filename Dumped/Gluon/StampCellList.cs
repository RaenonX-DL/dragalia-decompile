using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class StampCellList : PageScrollCell<StampPageData>
	{
		[SerializeField]
		private StampCell[] stamps;

		public UnityAction<int> onIconPressed;

		public override void UpdateContent(StampPageData data)
		{
		}

		public void OnIconPressed(int iconIndex)
		{
		}
	}
}
