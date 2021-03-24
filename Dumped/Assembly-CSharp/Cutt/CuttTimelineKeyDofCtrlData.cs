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
	public class CuttTimelineKeyDofCtrlData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public bool isEnableDof;
		public float focalSize;
		public float focalLength;
		public float smoothness;
		public float smoothStepMin;
		public float smoothStepMax;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyDofCtrlData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
