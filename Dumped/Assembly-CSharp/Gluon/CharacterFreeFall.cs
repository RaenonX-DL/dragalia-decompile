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
	public class CharacterFreeFall
	{
		// Fields
		private State state;
		private ActionMoveGravity fallAction;
		private float checkTimer;
		private const float threshold = 0.01f;
		private const float checkInterval = 0.5f;
		private static readonly int layerMask;
		[CompilerGenerated]
		private Vector3 _safePosition_k__BackingField;
	
		// Properties
		public Vector3 safePosition { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum State
		{
			None = 0,
			Fall = 1
		}
	
		// Constructors
		public CharacterFreeFall();
		static CharacterFreeFall();
	
		// Methods
		public void Initialize();
		public void Update(CharacterBase owner, float delta);
		public bool IsActive();
	}
}
