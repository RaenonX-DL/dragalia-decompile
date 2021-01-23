/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsInitializeWeak : ActionParts
	{
		// Fields
		private readonly InitializeWeakData _partsData;
		private bool _isInitializeWeakDone;
	
		// Constructors
		public ActionPartsInitializeWeak(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		public override void Clear();
		private void InitializeWeak();
	}
}
