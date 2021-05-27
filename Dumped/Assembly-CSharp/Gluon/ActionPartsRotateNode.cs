/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Dungeon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsRotateNode : ActionParts
	{
		// Fields
		private readonly RotateNodeData _partsData;
		private GameObject _node;
		private DungeonBgArtistAddRotate _ctrl;
	
		// Constructors
		public ActionPartsRotateNode(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		private void Procedure();
	}
}
