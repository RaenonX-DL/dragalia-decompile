﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EquipUnitListCell : CommonIconListCell
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public FlRoot flRoot;
			public GameObject releaseEffectObject;
			public Action endCallBack;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _PlayUnlockSkillEffect_b__0();
			internal void _PlayUnlockSkillEffect_b__1();
		}
	
		// Constructors
		public EquipUnitListCell();
	
		// Methods
		public override void UpdateContent(CommonIconListCellData data);
		public void PlayUnlockSkillEffect(Action endCallBack = null);
	}
}
