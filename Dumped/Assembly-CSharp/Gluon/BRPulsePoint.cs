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
	public class BRPulsePoint : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private BRPulse pulse;
		[SerializeField]
		[Tooltip]
		public float radius;
		[SerializeField]
		[Tooltip]
		private DungeonManager.eStageDifficulty stageDifficulty;
	
		// Properties
		public DungeonManager.eStageDifficulty StageDifficulty { get; }
	
		// Constructors
		public BRPulsePoint();
	
		// Methods
		private void Awake();
	}
}
