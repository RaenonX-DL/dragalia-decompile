using UnityEngine;

namespace Cutt
{
	public class CuttTimelineCharacter
	{
		private class MotionControlData
		{
			public int playFrame;

			public string stateName;

			public int layerIndex;

			public bool isRandom;

			public float minRandomSec;

			public float maxRandomSec;

			public float intervalRatio;

			public float randomTime;

			public float currentRandomTime;

			public bool trigger;

			public string triggerName;
		}

		private CuttTimelineCharacterData _keys;

		private CuttTimelineControl timelineControl;

		private MotionControlData[] motionControlData;

		private CuttTimelineKeyCharacterTransformDataList transformKeys;

		private CuttTimelineKeyCharacterMotionDataList motionKeys;

		private CuttTimelineKeyCharacterEyeDataList eyeKeys;

		private CuttTimelineKeyCharacterMouthDataList mouthKeys;

		private CuttTimelineKeyCharacterMotionDataList motion2Keys;

		private CuttTimelineKeyCharacterMotionDataList motion3Keys;

		private CuttTimelineKeyCharacterMotionDataList motion4Keys;

		private CuttTimelineKeyCharacterMotionDataList motion5Keys;

		private CuttTimelineKeyCharacterGameObjectDataList gameObjectKeys;

		private CuttTimelineKeyCharacterRichDataList richKeys;

		private CuttTimelineKeyCharacterMotionDataList[] motionKeysArray;

		private CuttCharacterController _character;

		private bool isBillboard;

		public CuttCharacterController character
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Initialize(CuttTimelineCharacterData keys, CuttTimelineControl timelineControl, CuttCharacterController charaController)
		{
		}

		public void ResetCharacterController(CuttCharacterController charaController)
		{
		}

		public void ResetCharacterController(CuttCharacterController charaController, RuntimeAnimatorController animController)
		{
		}

		public void AlterUpdate(float currentTime, float targetFps, int currentFrame, int oldFrame)
		{
		}

		public void AlterLateUpdate(float currentTime, float targetFps, int currentFrame, int oldFrame)
		{
		}

		private float GetCurrentMotionNormalizeTime(int layerIndex, int currentFrame, float targetFps)
		{
			return default(float);
		}

		public Transform FindTransform(string name)
		{
			return null;
		}

		public void SetBillboardRotation(Quaternion camRot)
		{
		}
	}
}
