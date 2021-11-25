using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Video;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidVideoClient : IVideoClient
	{
		private class OnCaptureOverlayStateListenerProxy : AndroidJavaProxy
		{
			private CaptureOverlayStateListener mListener;

			public OnCaptureOverlayStateListenerProxy(CaptureOverlayStateListener listener)
			{
			}

			public void onCaptureOverlayStateChanged(int overlayState)
			{
			}

			private static VideoCaptureOverlayState FromVideoCaptureOverlayState(int overlayState)
			{
				return default(VideoCaptureOverlayState);
			}
		}

		private AndroidJavaObject mVideosClient;

		private bool mIsCaptureSupported;

		private OnCaptureOverlayStateListenerProxy mOnCaptureOverlayStateListenerProxy;

		public AndroidVideoClient(bool isCaptureSupported, AndroidJavaObject account)
		{
		}

		public void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback)
		{
		}

		public void ShowCaptureOverlay()
		{
		}

		public void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback)
		{
		}

		public void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback)
		{
		}

		public bool IsCaptureSupported()
		{
			return default(bool);
		}

		public void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener)
		{
		}

		public void UnregisterCaptureOverlayStateChangedListener()
		{
		}

		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		private static VideoQualityLevel FromVideoQualityLevel(int captureQualityJava)
		{
			return default(VideoQualityLevel);
		}

		private static VideoCaptureMode FromVideoCaptureMode(int captureMode)
		{
			return default(VideoCaptureMode);
		}

		private static int ToVideoCaptureMode(VideoCaptureMode captureMode)
		{
			return default(int);
		}

		private static VideoCaptureState CreateVideoCaptureState(AndroidJavaObject videoCaptureState)
		{
			return null;
		}

		private static VideoCapabilities CreateVideoCapabilities(AndroidJavaObject videoCapabilities)
		{
			return null;
		}
	}
}
