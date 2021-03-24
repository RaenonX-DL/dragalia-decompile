/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionMoveExecution
	{
		// Fields
		private CharacterBase owner;
	
		// Constructors
		public ActionMoveExecution();
	
		// Methods
		public void Initialize(CharacterBase chara);
		public void UpdateTranslateByVelocity(Vector3 velocity);
		public void UpdateTranslateXZ(Vector3 targetPos);
		public void UpdateTranslateY(Vector3 targetPos);
		public void AddDifferenceY(Vector3 targetPos);
	}
}
