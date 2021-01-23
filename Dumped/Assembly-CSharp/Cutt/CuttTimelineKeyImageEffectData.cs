/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyImageEffectData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public ImageEffectType imageEffectType;
		public bool isFadeIn;
		public float fadeValue;
		public bool isStopProduction;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Nested types
		public enum ImageEffectType
		{
			None = 0,
			ChronosStopProduction = 1
		}
	
		// Constructors
		public CuttTimelineKeyImageEffectData();
	}
}
