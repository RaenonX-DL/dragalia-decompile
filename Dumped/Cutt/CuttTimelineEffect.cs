using System.Collections.Generic;
using Gluon;
using UnityEngine;

namespace Cutt
{
	public class CuttTimelineEffect
	{
		private CuttTimelineKeyEffectDataList _keys;

		private CuttTimelineControl _timelineControl;

		private string effectName;

		private EffectObject effectObject;

		private int lastPlayFrame;

		private int lastTriggerFrame;

		private Transform attachTransform;

		private CuttLayer.Type lastLayerType;

		private static readonly string storyEffectTag;

		private static List<string> storyEffectGroupList;

		private int ignoreSkipEventFrame;

		public static void LoadEffect(string effectName)
		{
		}

		public static void ReleaseStoryEffect()
		{
		}

		public void Initialize(CuttTimelineKeyEffectDataList keys, CuttTimelineControl timelineControl)
		{
		}

		public void Reset(int resetFrame)
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame)
		{
		}

		private Vector3 GetGeneralOffset(bool ignoreFlag)
		{
			return default(Vector3);
		}

		public void Stop()
		{
		}

		private void SetAttachTransform(CuttCharacterInitializer.CharacterId charaId, string name)
		{
		}
	}
}
