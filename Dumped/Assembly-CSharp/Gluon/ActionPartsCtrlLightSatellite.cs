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
	public class ActionPartsCtrlLightSatellite : ActionParts
	{
		// Fields
		private readonly CtrlLightSatelliteData _partsData;
	
		// Constructors
		public ActionPartsCtrlLightSatellite(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		protected override void OnStart();
		public override void Clear();
		private void Proc();
		private void CreateCtrlYinYang(CharacterBase target);
	}
}
