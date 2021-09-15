/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ScaleBlastUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private int _reservedActionId;
	
		// Constructors
		public ScaleBlastUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public override void FastUpdate();
		public void Setup(int reservedActionId);
		public override void OnChangeState(CharacterState state);
	}
}
