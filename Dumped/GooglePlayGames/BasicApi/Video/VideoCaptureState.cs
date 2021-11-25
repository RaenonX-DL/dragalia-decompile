namespace GooglePlayGames.BasicApi.Video
{
	public class VideoCaptureState
	{
		private bool mIsCapturing;

		private VideoCaptureMode mCaptureMode;

		private VideoQualityLevel mQualityLevel;

		private bool mIsOverlayVisible;

		private bool mIsPaused;

		public bool IsCapturing => default(bool);

		public VideoCaptureMode CaptureMode => default(VideoCaptureMode);

		public VideoQualityLevel QualityLevel => default(VideoQualityLevel);

		public bool IsOverlayVisible => default(bool);

		public bool IsPaused => default(bool);

		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
