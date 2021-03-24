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
	public class CuttTimelineCharacter
	{
		// Fields
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
	
		// Properties
		public CuttCharacterController character { get; set; }
	
		// Nested types
		private class MotionControlData
		{
			// Fields
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
	
			// Constructors
			public MotionControlData();
		}
	
		// Constructors
		public CuttTimelineCharacter();
	
		// Methods
		public void Initialize(CuttTimelineCharacterData keys, CuttTimelineControl timelineControl, CuttCharacterController charaController);
		public void ResetCharacterController(CuttCharacterController charaController);
		public void ResetCharacterController(CuttCharacterController charaController, RuntimeAnimatorController animController);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame, int oldFrame);
		public void AlterLateUpdate(float currentTime, float targetFps, int currentFrame, int oldFrame);
		private float GetCurrentMotionNormalizeTime(int layerIndex, int currentFrame, float targetFps);
		public Transform FindTransform(string name);
		public void SetBillboardRotation(Quaternion camRot);
	}
}
