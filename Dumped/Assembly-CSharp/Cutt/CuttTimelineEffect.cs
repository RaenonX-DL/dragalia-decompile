/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineEffect
	{
		// Fields
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
	
		// Constructors
		public CuttTimelineEffect();
		static CuttTimelineEffect();
	
		// Methods
		public static void LoadEffect(string effectName);
		public static void ReleaseStoryEffect();
		public void Initialize(CuttTimelineKeyEffectDataList keys, CuttTimelineControl timelineControl);
		public void Reset();
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
		private Vector3 GetGeneralOffset(bool ignoreFlag);
		public void Stop();
		private void SetAttachTransform(CuttCharacterInitializer.CharacterId charaId, string name);
	}
}
