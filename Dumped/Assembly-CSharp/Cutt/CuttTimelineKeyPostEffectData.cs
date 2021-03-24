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
	public class CuttTimelineKeyPostEffectData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public float blurSize;
		public bool isEnableDiffusionColor;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyPostEffectData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
