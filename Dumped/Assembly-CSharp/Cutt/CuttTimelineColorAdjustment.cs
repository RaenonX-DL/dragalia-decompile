/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineColorAdjustment
	{
		// Fields
		[CompilerGenerated]
		private bool _isEnableColorAdjustment_k__BackingField;
		[CompilerGenerated]
		private float _bright_k__BackingField;
		[CompilerGenerated]
		private float _saturation_k__BackingField;
		[CompilerGenerated]
		private float _contrast_k__BackingField;
		private CuttTimelineKeyColorAdjustmentDataList _keys;
	
		// Properties
		public bool isEnableColorAdjustment { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float bright { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float saturation { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float contrast { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CuttTimelineColorAdjustment();
	
		// Methods
		public void Initialize(CuttTimelineKeyColorAdjustmentDataList keys);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
	}
}
