/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterCustomPointController_CRS : CharacterCustomPointController
	{
		// Fields
		protected List<float> conditionValueList;
	
		// Properties
		public override int maxCP { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public CharacterCustomPointController_CRS __4__this;
			public int index;
			public ObscuredInt lastCP;
			public int value;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _SetCP_b__0();
		}
	
		// Constructors
		public CharacterCustomPointController_CRS();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void AttachToUI();
		public override void SetCP(int index, int value);
		private void OnGaugeAnimComplete(int index, int lastCP, int curCP);
		private void OnCPMatched(AbilityDataElement ade);
		public override IconType GetIconType();
		public override bool ClearCPOnReborn();
		public override int GetChargeLevel();
	}
}
