using System;
using UnityEngine;

namespace FLATOUT.Main
{
	public class FlMonoBehaviour : MonoBehaviour
	{
		protected bool _visible;

		[NonSerialized]
		public bool _visibleInHierarchy;

		public bool Visible => default(bool);

		public bool VisibleInHierarchy => default(bool);

		public virtual void SetVisible(bool visible)
		{
		}
	}
}
