/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineImageEffect
	{
		// Fields
		private CuttTimelineKeyImageEffectDataList _keys;
	
		// Constructors
		public CuttTimelineImageEffect();
	
		// Methods
		public void Initialize(CuttTimelineKeyImageEffectDataList keys, CuttTimelineControl timelineControl);
		public void Reset();
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
		public ImageEffectCtrlCronos GetImageEffectCtrlChronos();
		private void SetImageEffectCtrlChronos(bool isFadeIn, float fadeValue, bool isStopProduction);
	}
}
