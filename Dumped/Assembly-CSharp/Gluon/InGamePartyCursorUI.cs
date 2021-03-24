/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGamePartyCursorUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private SpriteRenderer cursorSpriteRenderer;
		[SerializeField]
		private SpriteRenderer playerNoImage;
		[Header]
		[SerializeField]
		private Sprite[] playerNoIcon;
		[Header]
		[SerializeField]
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
	
		// Constructors
		public InGamePartyCursorUI();
	
		// Methods
		public void Initialize(InGamePartyButtonUI[] partyUI);
		private void OnCompleteMove();
		private void OnCompleteBound();
		public void OnUpdateMove(Vector3 from, Vector3 to, float v);
		public void SetCursor(int index, bool immediate = false);
		public void SetPlayerNo(int no);
		[CompilerGenerated]
		private void _Initialize_b__13_0(float v);
		[CompilerGenerated]
		private void _Initialize_b__13_1(float v);
	}
}
