/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public struct OnCollidedEffectResult
	{
		// Fields
		[CompilerGenerated]
		private bool _hasDesignatedHitEffect_k__BackingField;
		[CompilerGenerated]
		private long _designatedHitEffectResourceId_k__BackingField;
		[CompilerGenerated]
		private bool _hasDesignatedHitSE_k__BackingField;
		[CompilerGenerated]
		private bool _isPlayNormalHitSE_k__BackingField;
	
		// Properties
		public bool hasDesignatedHitEffect { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public long designatedHitEffectResourceId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool hasDesignatedHitSE { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isPlayNormalHitSE { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Methods
		public void SetIsEffectDesignated(long resourceId = 0);
		public void SetIsSEDesignated(bool isPlayNormalHitSE, long resourceId = 0);
		public void Clear();
	}
}
