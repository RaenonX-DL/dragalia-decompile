using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BootyInfoUI2 : BootyInfoUIBase
	{
		[SerializeField]
		[Header("component")]
		private RectTransform dpointIconRt;

		[SerializeField]
		private RectTransform dpointRareInfoRt;

		[SerializeField]
		private Text dpointText;

		[SerializeField]
		private Text dpointRareText;

		[SerializeField]
		[Header("parameter")]
		protected float displayTime;

		protected float displayTimer;

		public static BootyInfoUI2 Create(GameObject parent)
		{
			return null;
		}

		protected override void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void MoveIn()
		{
		}

		public override void SetDPoint(int val)
		{
		}

		public override void SetDPointRare(int val)
		{
		}
	}
}
