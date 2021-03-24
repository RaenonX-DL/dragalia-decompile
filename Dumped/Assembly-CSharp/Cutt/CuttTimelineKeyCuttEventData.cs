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
	public class CuttTimelineKeyCuttEventData : CuttTimelineKey, ICuttTimelineKeyHasColor
	{
		// Fields
		public CuttEventType cuttEventType;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCuttEventData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public Color GetRepresentativeColor();
	}
}
