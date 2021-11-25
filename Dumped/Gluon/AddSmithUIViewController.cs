using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AddSmithUIViewController : FortLeftSideUIViewController
	{
		[SerializeField]
		private Button addButton;

		[SerializeField]
		private Text text;

		private FortModel model;

		protected virtual void Awake()
		{
		}

		public void UpdateContent()
		{
		}

		public void SetButtonEnable(bool flag)
		{
		}
	}
}
