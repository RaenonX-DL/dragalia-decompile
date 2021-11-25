using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingSearchBlock : FastUpdateMonoBehaviour
	{
		[SerializeField]
		private Image[] colorBlocks;

		private int[] blockOnTable;

		private int blockIndex;

		private int blockUpdateCount;

		private const int blockUpdateFrame = 2;

		private Color blockColorOn;

		private Color blockColorOff;

		public override void FastUpdate()
		{
		}
	}
}
