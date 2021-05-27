/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RaidBoostEventCharaCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text eventCharaBoostText;
		[SerializeField]
		private EventAbilityCell eventCharaBoostCell;
		[SerializeField]
		private CommonIcon eventCharaIcon;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public int charaId;
	
			// Constructors
			public __c__DisplayClass3_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_1
		{
			// Fields
			public bool inSelf;
			public __c__DisplayClass3_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass3_1();
	
			// Methods
			internal void _SetContent_b__0();
		}
	
		// Constructors
		public RaidBoostEventCharaCell();
	
		// Methods
		public void SetContent(RaidBoostPopup.RaidBoostModel.RaidEventAbilityChara abilityCharaData);
	}
}
