using System;
using UnityEngine;

namespace Gluon
{
	public class InGameFollowLayout : MonoBehaviour
	{
		[SerializeField]
		[Header("parameter")]
		public float height;

		[HideInInspector]
		public int priority;

		[HideInInspector]
		public bool valid;

		[HideInInspector]
		public Action attachFunc;

		[HideInInspector]
		public Action<InGameFollowLayout, bool> validFunc;

		private RectTransform rt;

		private Vector2 pos;

		private bool initialized;

		public void Initialize()
		{
		}

		public void OnAttached()
		{
		}

		public void Valid(bool v)
		{
		}

		public void SetOffset(float y)
		{
		}
	}
}
