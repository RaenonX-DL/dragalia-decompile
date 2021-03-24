/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsPuppet : ActionParts
	{
		// Fields
		private readonly PuppetData _partsData;
		private PuppetMasterUniqueCtrl ctrl;
		private bool _isDone;
	
		// Nested types
		public enum Mode
		{
			Boot = 0,
			Abort = 1,
			Setup = 2
		}
	
		// Constructors
		public ActionPartsPuppet(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		private void Proc();
		private void Setup();
		private void Boot();
		private void Abort();
	}
}
