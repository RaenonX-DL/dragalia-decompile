/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UIImageMaskToAlpha : MonoBehaviour
	{
		// Fields
		private bool _initializedFlag;
		private Image _maskImage;
		private Image[] _targetImageArray;
		private int _materialId_MaskTex;
		private float _canvasWidth;
		private ImageData[] _targetDataArray;
	
		// Nested types
		public class ImageData
		{
			// Fields
			public bool isCuteSprite;
			public Vector2 addOffset;
	
			// Constructors
			public ImageData();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UIImageMaskToAlpha __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public UIImageMaskToAlpha();
	
		// Methods
		[IteratorStateMachine]
		public IEnumerator Start();
		public Vector2 GetParentCanvasPixel(Transform parent);
		public void Initialize();
		public void ResetImageDataQue();
		private void LateUpdate();
		private void UpdateMaterial();
	}
}
