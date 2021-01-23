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
	public class FingerUI : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private RectTransform pointNode;
		[SerializeField]
		private RectTransform rotNode;
		[Header]
		[SerializeField]
		private int repeatCount;
		[SerializeField]
		private float moveTime;
		[SerializeField]
		private float waitTime;
		[SerializeField]
		private float distance;
		[Header]
		[SerializeField]
		private float swipeRotate;
		[SerializeField]
		private float swipeDistance;
		[SerializeField]
		private float swipeTime1;
		[SerializeField]
		private float swipeWaitTime;
		[SerializeField]
		private float swipeTime2;
		private int count;
		private Tweener tweenerPoint;
		private Tweener tweenerSwipe;
		private RectTransform rectTransform;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public FingerUI __4__this;
			public bool isLeft;
			public TweenCallback __9__2;
			public TweenCallback __9__1;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _DoAnimation_b__0();
			internal void _DoAnimation_b__1();
			internal void _DoAnimation_b__2();
		}
	
		// Constructors
		public FingerUI();
	
		// Methods
		public static FingerUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public bool IsActive();
		public void Open(Vector2 pos, float rotateZ = 0f, bool isLeft = false);
		public void OpenSwipe(Vector2 pos);
		public void Close();
		public void Release();
		private void DoAnimation(bool isLeft);
		public void SetPosition(Vector2 pos);
		private void OnUpdatePoint(float value);
		private void OnCompletePoint0();
		private void OnCompletePoint1();
		private void OnUpdateSwipe(float value);
		private void OnCompleteSwipe0();
		private void OnCompleteSwipe1();
	}
}
