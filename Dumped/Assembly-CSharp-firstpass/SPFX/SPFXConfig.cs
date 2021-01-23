/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	public class SPFXConfig : ScriptableObject
	{
		// Fields
		private static readonly string CONFIG_FILE_NAME;
		private static SPFXConfig m_Instance;
		public uint FileLoadMilliSecondPerOneFrame;
		public uint FileLoadMilliSecondPerOneFrameOnEditor;
		public int MaxFileCount;
		public int MaxFileCountOnEditor;
		public int MaxInstanceCount;
		public int MaxInstanceCountOnEditor;
		public int UnitMemorySize;
		public int UnitMemorySizeOnEditor;
		public int TemporaryMemorySize;
		public int TemporaryMemorySizeOnEditor;
		public int DrawCommandMemorySize;
		public int DrawCommandMemorySizeOnEditor;
		public int VertexBufferSize;
		public int VertexBufferSizeOnEditor;
		public bool IsDynamicLoadVfxb;
		public bool IsTextureRelativePath;
		public string VfxbRootDirectory;
		public string TextureAbsDirectory;
		public string PrefabsDirectory;
		public bool IsRadialBlurInclude;
		public bool IsEnableUnityCollision;
		public float FakeCollisionGroundY;
		public bool IsEnableSoundCallback;
		public bool IsEnableClipEventCallback;
		public bool IsEnablePositionNotificationCallback;
		public string ShaderBinaryFilePath;
		public bool IsMultithreadingUpdate;
		public bool IsAutoViewCullingEnable;
		public float AutoViewCullingRadius;
		public bool IsAutoDistanceClipEnable;
		public float AutoViewDistanceClipDistance;
		public bool IsCallInstanceCallback;
	
		// Properties
		public static SPFXConfig Instance { get; }
	
		// Constructors
		public SPFXConfig();
		static SPFXConfig();
	}
}
