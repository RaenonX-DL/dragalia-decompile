/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class AnimationStateData
	{
		// Fields
		internal SkeletonData skeletonData;
		private readonly Dictionary<AnimationPair, float> animationToMixTime;
		internal float defaultMix;
	
		// Properties
		public SkeletonData SkeletonData { get; }
		public float DefaultMix { get; set; }
	
		// Nested types
		private struct AnimationPair
		{
			// Fields
			public readonly Animation a1;
			public readonly Animation a2;
	
			// Constructors
			public AnimationPair(Animation a1, Animation a2);
	
			// Methods
			public override string ToString();
		}
	
		private class AnimationPairComparer : IEqualityComparer<AnimationPair>
		{
			// Fields
			internal static readonly AnimationPairComparer Instance;
	
			// Constructors
			public AnimationPairComparer();
			static AnimationPairComparer();
	
			// Methods
			bool System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.Equals(AnimationPair x, AnimationPair y);
			int System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.GetHashCode(AnimationPair obj);
		}
	
		// Constructors
		public AnimationStateData(SkeletonData skeletonData);
	
		// Methods
		public void SetMix(string fromName, string toName, float duration);
		public void SetMix(Animation from, Animation to, float duration);
		public float GetMix(Animation from, Animation to);
	}
}
