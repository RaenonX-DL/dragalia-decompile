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
	public class VideoCapabilities
	{
		// Fields
		private bool mIsCameraSupported;
		private bool mIsMicSupported;
		private bool mIsWriteStorageSupported;
		private bool[] mCaptureModesSupported;
		private bool[] mQualityLevelsSupported;
	
		// Properties
		public bool IsCameraSupported { get; }
		public bool IsMicSupported { get; }
		public bool IsWriteStorageSupported { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool, string> __9__14_0;
			public static Func<bool, string> __9__14_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _ToString_b__14_0(bool p);
			internal string _ToString_b__14_1(bool p);
		}
	
		// Constructors
		internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported);
	
		// Methods
		public bool SupportsCaptureMode(VideoCaptureMode captureMode);
		public bool SupportsQualityLevel(VideoQualityLevel qualityLevel);
		public override string ToString();
	}
}
