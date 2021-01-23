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
	public class ActionPartsShaderParam : ActionParts
	{
		// Fields
		private readonly ShaderParamData _partsData;
		private ShaderParamData.ResetFlags _resetFlags;
	
		// Constructors
		public ActionPartsShaderParam(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnFinish();
		private void UpdateShaderParameter();
		private void SetResetShaderParameter();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		public override void Stop();
	}
}
