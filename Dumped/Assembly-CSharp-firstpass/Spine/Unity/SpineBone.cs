/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class SpineBone : SpineAttributeBase
	{
		// Constructors
		public SpineBone(string startsWith = "", string dataField = "", bool includeNone = true, bool fallbackToTextField = false);
	
		// Methods
		public static Bone GetBone(string boneName, SkeletonRenderer renderer);
		public static BoneData GetBoneData(string boneName, SkeletonDataAsset skeletonDataAsset);
	}
}
