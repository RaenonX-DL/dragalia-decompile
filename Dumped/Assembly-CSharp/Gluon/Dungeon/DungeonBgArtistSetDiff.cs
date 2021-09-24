/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonBgArtistSetDiff : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private List<Transform> targetNodeList;
		[SerializeField]
		private SetActiveType setTargetNodeActiveType;
		[SerializeField]
		private bool searchTargetChildren;
		[SerializeField]
		private bool destroyCollider;
	
		// Nested types
		public enum SetActiveType
		{
			None = 0,
			Enable = 1,
			Disable = 2
		}
	
		// Constructors
		public DungeonBgArtistSetDiff();
	
		// Methods
		private void Awake();
	}
}
