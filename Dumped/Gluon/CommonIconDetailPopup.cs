using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonIconDetailPopup : CommonPopup
	{
		[SerializeField]
		[Header("ExitUIPublisher")]
		protected AnimationUIAutoPublisher exitUIPublisher;

		[SerializeField]
		[Header("Content")]
		public CommonIcon icon;

		public Text itemName;

		public Text description;

		protected Action onOKOrClose;

		protected Action onCancel;

		private CommonIcon iconSource;

		public static CommonIconDetailPopup Create(CommonIcon icon)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public virtual void OnOKOrClosePopup()
		{
		}

		public virtual void OnCancelPopup()
		{
		}
	}
}
