/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ScreenshotCapture : MonoBehaviour
	{
		// Fields
		private static ScreenshotCapture _instance;
		[SerializeField]
		private Texture2D _image;
		private int _idx;
	
		// Properties
		public static ScreenshotCapture instance { get; }
		public static bool hasInstance { get; }
		public Texture2D image { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Co_Capture_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ScreenshotCapture __4__this;
			public int devide;
			public TextureFormat format;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Co_Capture_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SkipCo_Capture_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ScreenshotCapture __4__this;
			public int devide;
			public TextureFormat format;
			public UnityAction callback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SkipCo_Capture_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ScreenshotCapture();
	
		// Methods
		private void OnDestroy();
		public void Capture(int devide = 1, TextureFormat format = TextureFormat.ARGB32);
		[IteratorStateMachine]
		private IEnumerator Co_Capture(int devide, TextureFormat format);
		public void PrepareRenderTexture(int divide, TextureFormat format);
		public void RenderCameraGroupToImage(CameraGroup cameraGroup, int devide = 1);
		public void RenderCameraToImage(Camera cam, int devide = 1);
		public void SkipCapture(int devide = 1, TextureFormat format = TextureFormat.ARGB32, UnityAction callback = null);
		[IteratorStateMachine]
		private IEnumerator SkipCo_Capture(int devide, TextureFormat format, UnityAction callback);
		public void DestroyImage();
	}
}
