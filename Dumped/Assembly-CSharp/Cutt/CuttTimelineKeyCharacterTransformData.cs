/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterTransformData : CuttTimelineKeyTransformData
	{
		// Fields
		public bool active;
		public Vector3 shadowOffset;
		public Vector2 shadowScale;
		public bool isBillboard;
		public bool isUseAlpha;
		public float alpha;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCharacterTransformData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
