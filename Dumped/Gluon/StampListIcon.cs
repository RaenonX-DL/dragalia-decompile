using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StampListIcon : TableViewCell<StampListData>
	{
		public Image newIcon;

		public Image selectIcon;

		public Image nowSetIcon;

		public Image outIcon;

		public RawImage stampIcon;

		[SerializeField]
		public StampListButtonEvent buttonPressed;

		[SerializeField]
		public StampListButtonEvent buttonLongPressed;

		private void Start()
		{
		}

		public override void UpdateContent(StampListData data)
		{
		}

		private void OnButtonPressed()
		{
		}

		private void OnButtonLongPressed()
		{
		}
	}
}
