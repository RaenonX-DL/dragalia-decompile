/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterCustomPointController_RKS : CharacterCustomPointController
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public CharacterCustomPointController_RKS __4__this;
			public int index;
			public ObscuredInt lastCP;
			public int value;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _SetCP_b__0();
		}
	
		// Constructors
		public CharacterCustomPointController_RKS();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void SetCP(int index, int value);
		private void OnGaugeAnimComplete(int index, int lastCP, int curCP);
		private void OnCPMatched(AbilityDataElement ade);
		public override IconType GetIconType();
		[CompilerGenerated]
		private void _Initialize_b__0_0(int curMode, int prevMode);
	}
}
