/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateBoundary : CharacterStateBase
	{
		// Fields
		[CompilerGenerated]
		private CommonObjectStatus _target_k__BackingField;
	
		// Properties
		public int actionId { get; set; }
		public int boundaryDataId { get; set; }
		public CommonObjectStatus target { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public CharacterStateBoundary();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
	}
}
