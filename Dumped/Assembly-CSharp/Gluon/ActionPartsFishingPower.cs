﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsFishingPower : ActionParts
	{
		// Fields
		private readonly FishingPowerData _partsData;
		private FishUniqueCtrl _ctrl;
		private bool _isDone;
	
		// Constructors
		public ActionPartsFishingPower(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		public override void Clear();
		private void ProcCommand();
	}
}
