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
	public class ActionPartsOperateBg : ActionParts
	{
		// Fields
		private readonly OperateBgData _partsData;
		private bool _isDone;
	
		// Nested types
		public enum OperateType
		{
			ChangeTexture = 0,
			SwitchTransformParam = 1
		}
	
		// Constructors
		public ActionPartsOperateBg(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		public override void Clear();
		private void Proc();
	}
}
