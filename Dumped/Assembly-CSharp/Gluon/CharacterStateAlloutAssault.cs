/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateAlloutAssault : CharacterStateBase
	{
		// Fields
		private const string EFFECT_NAME = "EFF_EIG_003";
		private EffectObject _effectObject;
	
		// Constructors
		public CharacterStateAlloutAssault();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
		public override void OnDisconnectOwner();
		private void SetMeshVisibility(bool visibility);
	}
}
