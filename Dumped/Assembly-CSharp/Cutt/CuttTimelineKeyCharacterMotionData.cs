/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterMotionData : CuttTimelineKey
	{
		// Fields
		public string stateName;
		public bool isRandom;
		public float minRandomSec;
		public float maxRandomSec;
		public float intervalRatio;
		public bool trigger;
		public string triggerName;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCharacterMotionData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
