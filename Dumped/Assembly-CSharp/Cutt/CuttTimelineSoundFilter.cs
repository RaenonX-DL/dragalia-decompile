/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineSoundFilter
	{
		// Fields
		public CuttTimelineKeySoundFilterData.FilterType filterTypeLog;
		private CuttTimelineKeySoundFilterDataList _keys;
	
		// Constructors
		public CuttTimelineSoundFilter();
	
		// Methods
		public void Initialize(CuttTimelineKeySoundFilterDataList keys, CuttTimelineControl timelineControl);
		public void Reset();
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
		private void SetFilter(CuttTimelineKeySoundFilterData.FilterType type);
	}
}
