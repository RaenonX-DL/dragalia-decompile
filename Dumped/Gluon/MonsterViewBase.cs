using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class MonsterViewBase : MonoBehaviour
	{
		public UnityAction<MonsterDetailArrow> arrowButtonAction;

		public void ArrowButtonPressed(int arrowDirection)
		{
		}
	}
}
