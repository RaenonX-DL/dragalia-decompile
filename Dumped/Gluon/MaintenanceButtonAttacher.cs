using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class MaintenanceButtonAttacher : MonoBehaviour
	{
		public List<MaintenanceFunctionType> funcTypes;

		public PointerEventHandler handlerObject;

		private void Awake()
		{
		}
	}
}
