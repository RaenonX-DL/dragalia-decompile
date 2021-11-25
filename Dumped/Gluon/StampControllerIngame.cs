using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class StampControllerIngame : PageScrollController<StampPageData>
	{
		[SerializeField]
		[Header("component")]
		private StampCarsouseIcons carsouselIcons;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082«ã\u0083«ã\u0083¼ã\u0082»ã\u0083«ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®é\u0096\u0093é\u009a\u0094")]
		private float carsouseIconMergin;

		public UnityAction<int> pageButtonCallBack;

		protected int pageDataNum;

		private const string changePageSe = "SE_OUT_COMMON_0005";

		public bool Initialized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Start()
		{
		}

		private void OnIconPressed(int selectStampID)
		{
		}

		protected override void ChangePage(int index)
		{
		}

		public void ChangePageButton(int direction)
		{
		}

		private void UpdateCarsousel()
		{
		}

		public void ApplyCarsouselIcon()
		{
		}
	}
}
