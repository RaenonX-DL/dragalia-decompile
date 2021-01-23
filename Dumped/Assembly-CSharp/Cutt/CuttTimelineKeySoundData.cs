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
	public class CuttTimelineKeySoundData : CuttTimelineKeyTransformData, ICuttTimelineKeyHasColor
	{
		// Fields
		public CuttTimelineSoundOperationID operationId;
		public string soundName;
		public int fadeFrame;
		public bool isEndStop;
		public int endStopFadeFrame;
		public static readonly float volumePercentBase;
		public static readonly float volumePercentMax;
		[Range]
		public float volumePercent;
		public FadeKind fadeKind;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Nested types
		public enum FadeKind
		{
			Disable = 0,
			Enable = 1
		}
	
		// Constructors
		public CuttTimelineKeySoundData();
		static CuttTimelineKeySoundData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public Color GetRepresentativeColor();
		public float GetVolume();
	}
}
