/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Video
{
	public class VideoCaptureState
	{
		// Fields
		private bool mIsCapturing;
		private VideoCaptureMode mCaptureMode;
		private VideoQualityLevel mQualityLevel;
		private bool mIsOverlayVisible;
		private bool mIsPaused;
	
		// Properties
		public bool IsCapturing { get; }
		public VideoCaptureMode CaptureMode { get; }
		public VideoQualityLevel QualityLevel { get; }
		public bool IsOverlayVisible { get; }
		public bool IsPaused { get; }
	
		// Constructors
		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused);
	
		// Methods
		public override string ToString();
	}
}
