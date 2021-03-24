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
	[Serializable]
	public class CuttTimelineKeyCharaMotionData : CuttTimelineKey
	{
		// Fields
		public string motionName;
		public AnimationClip clip;
		public float motionHeadTime;
		public float playLength;
		public float playSpeed;
		public bool loop;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCharaMotionData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
