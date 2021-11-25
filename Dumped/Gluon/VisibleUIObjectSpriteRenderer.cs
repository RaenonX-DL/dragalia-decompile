using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class VisibleUIObjectSpriteRenderer : MonoBehaviour
	{
		private Transform trs;

		private SpriteRenderer spriteRenderer;

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
	}
}
