using UnityEngine;

namespace Gluon
{
	public class MyPageMoveMapBuilding : MonoBehaviour
	{
		public enum Type
		{
			Tavern,
			Inn,
			Shop
		}

		public Type type;

		private void Awake()
		{
		}
	}
}
