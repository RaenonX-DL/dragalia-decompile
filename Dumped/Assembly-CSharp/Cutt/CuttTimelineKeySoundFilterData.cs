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
	public class CuttTimelineKeySoundFilterData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public FilterType filterType;
		public bool isFadeIn;
		public float fadeValue;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Nested types
		public enum FilterType
		{
			None = 0,
			DspBusEq = 1
		}
	
		// Constructors
		public CuttTimelineKeySoundFilterData();
	}
}
