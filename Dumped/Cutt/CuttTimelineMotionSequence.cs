using UnityEngine;

namespace Cutt
{
	public class CuttTimelineMotionSequence
	{
		private ICuttTimelineMSQTarget _target;

		private Animation _animation;

		private CuttTimelineKeyCharaMotionSeqDataList _keys;

		private int _indexOfPlayingKeyA;

		private int _indexOfPlayingKeyB;

		private CuttTimelineControl _timelineControl;

		public void Initialize(ICuttTimelineMSQTarget target, CuttTimelineKeyCharaMotionSeqDataList keys, CuttTimelineControl timelineControl)
		{
		}

		private bool SetupAnimationClip(CuttTimelineKeyCharaMotionData key)
		{
			return default(bool);
		}

		private void FindPlayingMot(out CuttTimelineKeyCharaMotionData a, out CuttTimelineKeyCharaMotionData b, out CuttTimelineKeyCharaMotionData lastKey, out int indexA, out int indexB, float t, float spf)
		{
		}

		public void AlterUpdate(float currentTime, float targetFps)
		{
		}

		private AnimationState GetAnimationState(CuttTimelineKeyCharaMotionData key)
		{
			return null;
		}
	}
}
