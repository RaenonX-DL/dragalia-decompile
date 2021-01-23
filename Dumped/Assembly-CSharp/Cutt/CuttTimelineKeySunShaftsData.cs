/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeySunShaftsData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		public PostEffectSunShafts.SunShaftsParam keySunShaftsData;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeySunShaftsData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public CuttTimelineKey Interpolate(CuttTimelineKey interpKey, CuttTimelineKey prevKey, float t);
	}
}
