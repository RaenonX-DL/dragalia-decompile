using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class VisibleUIObject : MonoBehaviour
	{
		private Transform trs;

		private Vector3 scale;

		private bool isActive;

		public void Initialize(bool visible = false, [Optional] GameObject obj)
		{
		}

		public bool IsVisible(bool inHierarchy = true)
		{
			return default(bool);
		}

		public void Visible(bool value)
		{
		}

		public void SetScale(Vector3 scl)
		{
		}
	}
}
