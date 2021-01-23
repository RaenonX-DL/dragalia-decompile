/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineDofCtrl
	{
		// Fields
		[CompilerGenerated]
		private bool _isEnableDof_k__BackingField;
		[CompilerGenerated]
		private DofFocalType _dofFocalType_k__BackingField;
		[CompilerGenerated]
		private float _focalSize_k__BackingField;
		[CompilerGenerated]
		private float _focalLength_k__BackingField;
		[CompilerGenerated]
		private float _smoothness_k__BackingField;
		[CompilerGenerated]
		private float _smoothStepMin_k__BackingField;
		[CompilerGenerated]
		private float _smoothStepMax_k__BackingField;
		private CuttTimelineKeyDofCtrlDataList _keys;
	
		// Properties
		public bool isEnableDof { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DofFocalType dofFocalType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float focalSize { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float focalLength { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float smoothness { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float smoothStepMin { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float smoothStepMax { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CuttTimelineDofCtrl();
	
		// Methods
		public void Initialize(CuttTimelineKeyDofCtrlDataList keys, CuttTimelineControl timelineControl);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
	}
}
