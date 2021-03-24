/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class SkeletonDataAsset : ScriptableObject
	{
		// Fields
		public AtlasAsset[] atlasAssets;
		public float scale;
		public TextAsset skeletonJSON;
		[SpineAnimation]
		public string[] fromAnimation;
		[SpineAnimation]
		public string[] toAnimation;
		public float[] duration;
		public float defaultMix;
		public RuntimeAnimatorController controller;
		private SkeletonData skeletonData;
		private AnimationStateData stateData;
	
		// Properties
		public bool IsLoaded { get; }
	
		// Constructors
		public SkeletonDataAsset();
	
		// Methods
		private void Reset();
		public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAsset atlasAsset, bool initialize, float scale = 0.01f);
		public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAsset[] atlasAssets, bool initialize, float scale = 0.01f);
		public void Clear();
		public SkeletonData GetSkeletonData(bool quiet);
		internal void InitializeWithData(SkeletonData sd);
		internal Atlas[] GetAtlasArray();
		internal static SkeletonData ReadSkeletonData(byte[] bytes, AttachmentLoader attachmentLoader, float scale);
		internal static SkeletonData ReadSkeletonData(string text, AttachmentLoader attachmentLoader, float scale);
		public void FillStateData();
		public AnimationStateData GetAnimationStateData();
	}
}
