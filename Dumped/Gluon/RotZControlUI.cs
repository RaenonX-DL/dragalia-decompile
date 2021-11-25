using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class RotZControlUI : MonoBehaviour
	{
		private RectTransform rt;

		private Tweener tweener;

		private Action<RotZControlUI> func;

		private bool isLeft;

		private Quaternion leftQuaternion;

		public void Initialize()
		{
		}

		public void RotateZ(float startZ, float endZ, Ease ease, float t, float delay, [Optional] Action<RotZControlUI> func, bool isLeft = false)
		{
		}

		private void OnUpdateRotate(float value)
		{
		}

		private void OnCompleteRotate()
		{
		}
	}
}
