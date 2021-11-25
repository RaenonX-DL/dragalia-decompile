using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class MoveControlUI : MonoBehaviour
	{
		[HideInInspector]
		public RectTransform rt;

		private Tweener tweener;

		private Action<MoveControlUI> func;

		private Vector2 fromPos;

		private Vector2 toPos;

		private Action<MoveControlUI> funcKill;

		public void Initialize()
		{
		}

		public void Move(Vector2 startPos, Vector2 endPos, Ease ease, float t, [Optional] Action<MoveControlUI> func, [Optional] Action<MoveControlUI> funcKill)
		{
		}

		public void Move(Vector2 startPos, Vector2 endPos, Ease ease, float t, float delay, [Optional] Action<MoveControlUI> func, [Optional] Action<MoveControlUI> funcKill)
		{
		}

		private void OnUpdateMove(float value)
		{
		}

		private void OnCompleteMove()
		{
		}

		private void OnKillMove()
		{
		}
	}
}
