using System.Threading.Tasks;
using UnityEngine;

namespace Gluon
{
	public class TotalDamageEventHistoryPopup : PopupBase
	{
		[SerializeField]
		private Transform layoutParent;

		[SerializeField]
		private GameObject emptyDataText;

		private GameObject originalCell;

		private int eventId;

		private static readonly string totalDamageEventHistoryPopupPath;

		private static readonly string totalDamageEventHistoryCellPath;

		public static TotalDamageEventHistoryPopup Create(int eventId)
		{
			return null;
		}

		private Task RequestTotalDamageHistoryData()
		{
			return null;
		}

		private Task UpdateContents()
		{
			return null;
		}
	}
}
