/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MoveControlUI : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public RectTransform rt;
		private Tweener tweener;
		private Action<MoveControlUI> func;
		private Vector2 fromPos;
		private Vector2 toPos;
		private Action<MoveControlUI> funcKill;
	
		// Constructors
		public MoveControlUI();
	
		// Methods
		public void Initialize();
		public void Move(Vector2 startPos, Vector2 endPos, Ease ease, float t, Action<MoveControlUI> func = null, Action<MoveControlUI> funcKill = null);
		public void Move(Vector2 startPos, Vector2 endPos, Ease ease, float t, float delay, Action<MoveControlUI> func = null, Action<MoveControlUI> funcKill = null);
		private void OnUpdateMove(float value);
		private void OnCompleteMove();
		private void OnKillMove();
	}
}
