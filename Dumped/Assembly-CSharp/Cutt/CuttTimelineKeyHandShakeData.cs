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
	public class CuttTimelineKeyHandShakeData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public bool enable;
		public bool isOverwrite;
		public float positionFrequency;
		public float rotationFrequency;
		public float positionAmount;
		public float rotationAmount;
		public Vector3 positionComponents;
		public Vector3 rotationComponents;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyHandShakeData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
