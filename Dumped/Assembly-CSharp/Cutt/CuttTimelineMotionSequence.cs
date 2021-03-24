/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineMotionSequence
	{
		// Fields
		private ICuttTimelineMSQTarget _target;
		private Animation _animation;
		private CuttTimelineKeyCharaMotionSeqDataList _keys;
		private int _indexOfPlayingKeyA;
		private int _indexOfPlayingKeyB;
		private CuttTimelineControl _timelineControl;
	
		// Constructors
		public CuttTimelineMotionSequence();
	
		// Methods
		public void Initialize(ICuttTimelineMSQTarget target, CuttTimelineKeyCharaMotionSeqDataList keys, CuttTimelineControl timelineControl);
		private bool SetupAnimationClip(CuttTimelineKeyCharaMotionData key);
		private void FindPlayingMot(out CuttTimelineKeyCharaMotionData a, out CuttTimelineKeyCharaMotionData b, out CuttTimelineKeyCharaMotionData lastKey, out int indexA, out int indexB, float t, float spf);
		public void AlterUpdate(float currentTime, float targetFps);
		private AnimationState GetAnimationState(CuttTimelineKeyCharaMotionData key);
	}
}
