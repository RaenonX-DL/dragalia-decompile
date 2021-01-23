/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChainCtrl
	{
		// Fields
		private static readonly AbilityTargetAction[] AllTargetActions;
		public float _timer;
		private float _validTime;
		private Dictionary<AbilityTargetAction, int> _chainNumDic;
		[CompilerGenerated]
		private bool _isPause_k__BackingField;
	
		// Properties
		public bool isPause { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public ChainCtrl();
		static ChainCtrl();
	
		// Methods
		public int GetChainNum(AbilityTargetAction targetAction = AbilityTargetAction.NONE);
		public void Update(PlayerCharacter owner);
		public void Reset();
		public void Add(PlayerCharacter owner, int actionId, int skillId, int num = 1, bool isIgnoreTransform = false);
		private void Add(AbilityTargetAction targetAction, int num = 1);
	}
}
