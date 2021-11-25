namespace GooglePlayGames.BasicApi.Video
{
	public class VideoCapabilities
	{
		private bool mIsCameraSupported;

		private bool mIsMicSupported;

		private bool mIsWriteStorageSupported;

		private bool[] mCaptureModesSupported;

		private bool[] mQualityLevelsSupported;

		public bool IsCameraSupported => default(bool);

		public bool IsMicSupported => default(bool);

		public bool IsWriteStorageSupported => default(bool);

		internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
		{
		}

		public bool SupportsCaptureMode(VideoCaptureMode captureMode)
		{
			return default(bool);
		}

		public bool SupportsQualityLevel(VideoQualityLevel qualityLevel)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
