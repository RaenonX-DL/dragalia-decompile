/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsServant : ActionParts
	{
		// Fields
		private readonly ServantData _partsData;
	
		// Properties
		public int popNum { get; }
	
		// Constructors
		public ActionPartsServant(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		private Vector3 CalcPopPos(int index);
	}
}
