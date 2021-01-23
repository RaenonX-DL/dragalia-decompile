/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CriMana
{
	public class MovieInfo
	{
		// Fields
		private uint _reserved1;
		private uint _hasAlpha;
		public uint width;
		public uint height;
		public uint dispWidth;
		public uint dispHeight;
		public uint framerateN;
		public uint framerateD;
		public uint totalFrames;
		private uint _codecType;
		private uint _alphaCodecType;
		public uint numAudioStreams;
		public AudioInfo[] audioPrm;
		public uint numSubtitleChannels;
		public uint maxSubtitleSize;
	
		// Properties
		public bool hasAlpha { get; set; }
		public CodecType codecType { get; set; }
		public CodecType alphaCodecType { get; set; }
	
		// Constructors
		public MovieInfo();
	}
}
