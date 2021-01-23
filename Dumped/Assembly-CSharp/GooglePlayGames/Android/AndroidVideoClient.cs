/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Video;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	internal class AndroidVideoClient : IVideoClient
	{
		// Fields
		private AndroidJavaObject mVideosClient;
		private bool mIsCaptureSupported;
		private OnCaptureOverlayStateListenerProxy mOnCaptureOverlayStateListenerProxy;
	
		// Nested types
		private class OnCaptureOverlayStateListenerProxy : AndroidJavaProxy
		{
			// Fields
			private CaptureOverlayStateListener mListener;
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass2_0
			{
				// Fields
				public OnCaptureOverlayStateListenerProxy __4__this;
				public int overlayState;
	
				// Constructors
				public __c__DisplayClass2_0();
	
				// Methods
				internal void _onCaptureOverlayStateChanged_b__0();
			}
	
			// Constructors
			public OnCaptureOverlayStateListenerProxy(CaptureOverlayStateListener listener);
	
			// Methods
			public void onCaptureOverlayStateChanged(int overlayState);
			private static VideoCaptureOverlayState FromVideoCaptureOverlayState(int overlayState);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public Action<ResponseStatus, VideoCapabilities> callback;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _GetCaptureCapabilities_b__0(AndroidJavaObject videoCapabilities);
			internal void _GetCaptureCapabilities_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public Action<ResponseStatus, VideoCaptureState> callback;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _GetCaptureState_b__0(AndroidJavaObject captureState);
			internal void _GetCaptureState_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public Action<ResponseStatus, bool> callback;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _IsCaptureAvailable_b__0(bool isCaptureAvailable);
			internal void _IsCaptureAvailable_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0<T1, T2>
		{
			// Fields
			public Action<T1, T2> toConvert;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _ToOnGameThread_b__0(T1 val1, T2 val2);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_1<T1, T2>
		{
			// Fields
			public T1 val1;
			public T2 val2;
			public __c__DisplayClass12_0<T1, T2> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass12_1();
	
			// Methods
			internal void _ToOnGameThread_b__1();
		}
	
		// Constructors
		public AndroidVideoClient(bool isCaptureSupported, AndroidJavaObject account);
	
		// Methods
		public void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback);
		public void ShowCaptureOverlay();
		public void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback);
		public void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback);
		public bool IsCaptureSupported();
		public void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener);
		public void UnregisterCaptureOverlayStateChangedListener();
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert);
		private static VideoQualityLevel FromVideoQualityLevel(int captureQualityJava);
		private static VideoCaptureMode FromVideoCaptureMode(int captureMode);
		private static int ToVideoCaptureMode(VideoCaptureMode captureMode);
		private static VideoCaptureState CreateVideoCaptureState(AndroidJavaObject videoCaptureState);
		private static VideoCapabilities CreateVideoCapabilities(AndroidJavaObject videoCapabilities);
	}
}
