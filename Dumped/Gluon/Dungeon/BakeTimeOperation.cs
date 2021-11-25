using System;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class BakeTimeOperation : MonoBehaviour
	{
		[Flags]
		private enum Operation
		{
			None = 0x0,
			ScaleX = 0x1,
			ScaleY = 0x2,
			ScaleZ = 0x4
		}

		[SerializeField]
		private Operation _operation;

		[SerializeField]
		[Tooltip("Bakeæ\u0099\u0082ã\u0081®ã\u0083­ã\u0083¼ã\u0082«ã\u0083«ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
		private Vector3 _localScale;
	}
}
