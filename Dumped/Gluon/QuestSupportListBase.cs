using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class QuestSupportListBase : MonoBehaviour
	{
		public UnityAction<QuestSupportListCellData> CellPressCallBack;

		public UnityAction MultiPlayCellPressCallBack;
	}
}
