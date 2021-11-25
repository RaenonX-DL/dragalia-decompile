using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class StampCellListIngame : PageScrollCell<StampPageData>
	{
		[SerializeField]
		private StampCellIngame[] stamps;

		public UnityAction<int> onIconPressed;

		public override void UpdateContent(StampPageData data)
		{
		}

		public void OnIconPressed(int iconIndex)
		{
		}
	}
}
