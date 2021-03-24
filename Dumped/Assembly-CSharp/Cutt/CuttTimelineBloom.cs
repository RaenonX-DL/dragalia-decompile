/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineBloom
	{
		// Fields
		[CompilerGenerated]
		private bool _isEnableBloom_k__BackingField;
		[CompilerGenerated]
		private float _bloomWeight_k__BackingField;
		[CompilerGenerated]
		private float _bloomThreshold_k__BackingField;
		[CompilerGenerated]
		private float _bloomIntensity_k__BackingField;
		private CuttTimelineKeyBloomDataList _keys;
	
		// Properties
		public bool isEnableBloom { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float bloomWeight { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float bloomThreshold { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float bloomIntensity { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CuttTimelineBloom();
	
		// Methods
		public void Initialize(CuttTimelineKeyBloomDataList keys);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
	}
}
