/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Video
{
	public interface IVideoClient
	{
		// Methods
		void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback);
		void ShowCaptureOverlay();
		void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback);
		void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback);
		bool IsCaptureSupported();
		void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener);
		void UnregisterCaptureOverlayStateChangedListener();
	}
}
