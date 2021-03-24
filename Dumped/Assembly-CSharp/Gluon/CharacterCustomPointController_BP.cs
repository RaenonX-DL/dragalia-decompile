/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterCustomPointController_BP : CharacterCustomPointController
	{
		// Fields
		private float fCp;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public CharacterCustomPointController_BP __4__this;
			public int index;
			public ObscuredInt prevCP;
			public int value;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _SetCP_b__0();
		}
	
		// Constructors
		public CharacterCustomPointController_BP();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void Update();
		public override void SetCP(int index, int value);
		private void OnGaugeAnimComplete(int index, int prevCP, int currCP);
		private void OnCPMatched(AbilityDataElement ade, int skillId, int skillIndex);
		public override IconType GetIconType();
		public override bool ClearCPOnContinue();
	}
}
