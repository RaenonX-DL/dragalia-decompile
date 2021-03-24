/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[RequireComponent]
	public class SkeletonAnimator : SkeletonRenderer, ISkeletonAnimation
	{
		// Fields
		[SerializeField]
		protected MecanimTranslator translator;
		[CompilerGenerated]
		private UpdateBonesDelegate _UpdateLocal;
		[CompilerGenerated]
		private UpdateBonesDelegate _UpdateWorld;
		[CompilerGenerated]
		private UpdateBonesDelegate _UpdateComplete;
	
		// Properties
		public MecanimTranslator Translator { get; }
	
		// Events
		protected event UpdateBonesDelegate _UpdateLocal {
			add;
			remove;
		}
		protected event UpdateBonesDelegate _UpdateWorld {
			add;
			remove;
		}
		protected event UpdateBonesDelegate _UpdateComplete {
			add;
			remove;
		}
		public event UpdateBonesDelegate UpdateLocal {
			add;
			remove;
		}
		public event UpdateBonesDelegate UpdateWorld {
			add;
			remove;
		}
		public event UpdateBonesDelegate UpdateComplete {
			add;
			remove;
		}
	
		// Nested types
		[Serializable]
		public class MecanimTranslator
		{
			// Fields
			public bool autoReset;
			public MixMode[] layerMixModes;
			private readonly Dictionary<int, Spine.Animation> animationTable;
			private readonly Dictionary<AnimationClip, int> clipNameHashCodeTable;
			private readonly List<Spine.Animation> previousAnimations;
			private readonly List<AnimatorClipInfo> clipInfoCache;
			private readonly List<AnimatorClipInfo> nextClipInfoCache;
			private Animator animator;
	
			// Properties
			public Animator Animator { get; }
	
			// Nested types
			public enum MixMode
			{
				AlwaysMix = 0,
				MixNext = 1,
				SpineStyle = 2
			}
	
			private class AnimationClipEqualityComparer : IEqualityComparer<AnimationClip>
			{
				// Fields
				internal static readonly IEqualityComparer<AnimationClip> Instance;
	
				// Constructors
				public AnimationClipEqualityComparer();
				static AnimationClipEqualityComparer();
	
				// Methods
				public bool Equals(AnimationClip x, AnimationClip y);
				public int GetHashCode(AnimationClip o);
			}
	
			private class IntEqualityComparer : IEqualityComparer<int>
			{
				// Fields
				internal static readonly IEqualityComparer<int> Instance;
	
				// Constructors
				public IntEqualityComparer();
				static IntEqualityComparer();
	
				// Methods
				public bool Equals(int x, int y);
				public int GetHashCode(int o);
			}
	
			// Constructors
			public MecanimTranslator();
	
			// Methods
			public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset);
			public void Apply(Skeleton skeleton);
			private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed);
			private static float AnimationTime(float normalizedTime, float clipLength, bool reversed);
			private void GetAnimatorClipInfos(int layer, out int clipInfoCount, out int nextClipInfoCount, out IList<AnimatorClipInfo> clipInfo, out IList<AnimatorClipInfo> nextClipInfo);
			private int NameHashCode(AnimationClip clip);
		}
	
		// Constructors
		public SkeletonAnimator();
	
		// Methods
		public override void Initialize(bool overwrite);
		public void Update();
	}
}
