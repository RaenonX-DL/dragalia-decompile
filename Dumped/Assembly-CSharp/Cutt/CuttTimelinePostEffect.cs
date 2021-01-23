/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelinePostEffect
	{
		// Fields
		[CompilerGenerated]
		private bool _isEnableDiffusionColor_k__BackingField;
		[CompilerGenerated]
		private float _blurSize_k__BackingField;
		private CuttTimelineKeyPostEffectDataList _keys;
	
		// Properties
		public bool isEnableDiffusionColor { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float blurSize { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CuttTimelinePostEffect();
	
		// Methods
		public void Initialize(CuttTimelineKeyPostEffectDataList keys, CuttTimelineControl timelineControl);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
	}
}
