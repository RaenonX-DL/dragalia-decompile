using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class EventRankingListBase : MonoBehaviour
	{
		public UnityAction<EventRankingListCellData> CellPressCallBack;
	}
}
