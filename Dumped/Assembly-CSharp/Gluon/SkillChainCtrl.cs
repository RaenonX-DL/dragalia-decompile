/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SkillChainCtrl
	{
		// Fields
		private PlayerCharacter owner;
		private float remainTime;
		private float durationTime;
		[CompilerGenerated]
		private bool _isPause_k__BackingField;
		[CompilerGenerated]
		private int _prevSkillIndex_k__BackingField;
	
		// Properties
		public bool isPause { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int prevSkillIndex { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public SkillChainCtrl(PlayerCharacter player, float chainSec);
	
		// Methods
		public void Update();
		public void Start(int idx);
		public void Reset();
		public bool IsActive();
	}
}
