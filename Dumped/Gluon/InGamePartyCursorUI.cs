using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class InGamePartyCursorUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private SpriteRenderer cursorSpriteRenderer;

		[SerializeField]
		private SpriteRenderer playerNoImage;

		[SerializeField]
		[Header("resource")]
		private Sprite[] playerNoIcon;

		[SerializeField]
		[Header("parameter")]
		private float moveTime;

		[SerializeField]
		private float boundTime;

		[SerializeField]
		private int boundY;

		private InGamePartyButtonUI[] partyUI;

		private Tweener moveTweener;

		private Tweener boundTweener;

		private int currentIdx;

		private Vector3 startPos;

		private Vector3 endPos;

		private Vector3 boundPos;

		public void Initialize(InGamePartyButtonUI[] partyUI)
		{
		}

		private void OnCompleteMove()
		{
		}

		private void OnCompleteBound()
		{
		}

		public void OnUpdateMove(Vector3 from, Vector3 to, float v)
		{
		}

		public void SetCursor(int index, bool immediate = false)
		{
		}

		public void SetPlayerNo(int no)
		{
		}
	}
}
