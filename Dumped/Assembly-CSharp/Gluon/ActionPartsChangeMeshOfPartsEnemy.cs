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
	public class ActionPartsChangeMeshOfPartsEnemy : ActionParts
	{
		// Fields
		private readonly ChangeMeshOfPartsEnemyData _partsData;
	
		// Nested types
		public enum PartsIndex
		{
			PartsA = 1,
			PartsB = 2,
			PartsC = 3,
			PartsD = 4
		}
	
		// Constructors
		public ActionPartsChangeMeshOfPartsEnemy(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		private void Procedure();
	}
}