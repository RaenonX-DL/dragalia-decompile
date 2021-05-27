/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyUICursorCtrl : FastUpdateMonoBehaviour
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
		private PartyUICtrl[] partyUI;
		private Tweener moveTweener;
		private Tweener boundTweener;
		private int currentIdx;
		private float startPosY;
		private float boundPosY;
	
		// Constructors
		public PartyUICursorCtrl();
	
		// Methods
		public void Initialize(PartyUICtrl[] partyUI);
		private void OnCompleteMove();
		private void OnCompleteBound();
		public void OnUpdateMove(float from, float to, float v);
		public void SetCursor(int index);
		public void SetPlayerNo(int no);
		[CompilerGenerated]
		private void _Initialize_b__12_0(float v);
		[CompilerGenerated]
		private void _Initialize_b__12_1(float v);
	}
}
