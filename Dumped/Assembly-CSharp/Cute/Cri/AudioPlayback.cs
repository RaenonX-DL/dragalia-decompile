/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public struct AudioPlayback
	{
		// Fields
		private CriAtomExPlayback criAtomExPlayback;
		[CompilerGenerated]
		private bool _IsError_k__BackingField;
		[CompilerGenerated]
		private SoundGroup _SoundGroup_k__BackingField;
		[CompilerGenerated]
		private bool _Is3dSound_k__BackingField;
		[CompilerGenerated]
		private int _AtomSourceListIndex_k__BackingField;
		[CompilerGenerated]
		private string _CueSheetName_k__BackingField;
		[CompilerGenerated]
		private string _CueName_k__BackingField;
		[CompilerGenerated]
		private int _CueId_k__BackingField;
	
		// Properties
		public uint PlaybackId { get; }
		public CriAtomExPlayback.Status Status { get; }
		public long Time { get; }
		public bool IsError { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public SoundGroup SoundGroup { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool Is3dSound { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int AtomSourceListIndex { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string CueSheetName { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string CueName { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int CueId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public AudioPlayback(CriAtomExPlayback playback, bool isError, SoundGroup soundGroup, bool is3dSound, int atomSourceListIndex, string cueSheetName, string cueName, int cueId);
	
		// Methods
		public bool GetNumPlayedSamples(out long numSamples, out int samplingRate);
		public bool GetFormatInfo(out CriAtomEx.FormatInfo info);
		public bool IsLoop();
		public float GetLoopLengthTime();
		public float GetIntroLengthTime();
		public static AudioPlayback Error(SoundGroup soundGroup);
	}
}
