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
	public class CuttTimelineKeyFadeData : CuttTimelineKeyWithInterpolate, ICuttTimelineKeyHasColor
	{
		// Fields
		public Color color;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyFadeData();
	
		// Methods
		public Color GetRepresentativeColor();
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
