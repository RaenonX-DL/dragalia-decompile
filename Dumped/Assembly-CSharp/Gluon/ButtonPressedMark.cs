/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ButtonPressedMark : MonoBehaviour
	{
		// Fields
		public RectTransform yesLeftRectTransform;
		public RectTransform yesRightRectTransform;
		public RectTransform noLeftRectTransform;
		public RectTransform noRightRectTransform;
		public CanvasGroup canvasGroup;
		public bool dontDestroyOnCompleted;
		private Transform oldParent;
		public bool ignoreTimeScale;
		public Type type;
		public Vector3 initialRootPos;
		public Vector3 initialYesLeftPos;
		public Vector3 initialYesRightPos;
		public Vector3 initialNoLeftPos;
		public Vector3 initialNoRightPos;
	
		// Nested types
		public enum Type
		{
			Yes = 0,
			No = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public ButtonPressedMark __4__this;
			public Vector3 startLeftPosition;
			public Vector3 startRightPosition;
			public Action<float> __9__2;
			public TweenCallback __9__3;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _OnDecidedYes_b__0(float value);
			internal void _OnDecidedYes_b__1();
			internal void _OnDecidedYes_b__2(float value);
			internal void _OnDecidedYes_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public ButtonPressedMark __4__this;
			public Vector3 startLeftPosition;
			public Vector3 startRightPosition;
			public Action<float> __9__2;
			public TweenCallback __9__3;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _OnDecidedNo_b__0(float value);
			internal void _OnDecidedNo_b__1();
			internal void _OnDecidedNo_b__2(float value);
			internal void _OnDecidedNo_b__3();
		}
	
		// Constructors
		public ButtonPressedMark();
	
		// Methods
		public static void Decided(GameObject buttonObject);
		private void Awake();
		private void Start();
		public void OnDecided();
		private void OnDecidedYes();
		private void OnDecidedNo();
		private void OnBeginAnimation();
		private void OnCompleted();
	}
}
