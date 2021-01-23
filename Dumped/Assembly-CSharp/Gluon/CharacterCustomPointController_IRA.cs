/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterCustomPointController_IRA : CharacterCustomPointController
	{
		// Constructors
		public CharacterCustomPointController_IRA();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void AttachToUI();
		public override void SetCP(int index, int value);
		private void OnGaugeAnimComplete(int index, int prevCP, int currCP);
		public override void OnSkill(int actionId, int skillId, int skillIndex);
		private void OnCPMatched(AbilityDataElement ade, int actionId, int skillId, int skillIndex);
		public override void OnContinue();
		public override IconType GetIconType();
	}
}
