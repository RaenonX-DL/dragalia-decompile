/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsUpthrust : ActionParts
	{
		// Fields
		private readonly UpthrustData _partsData;
		[CompilerGenerated]
		private List<EnemyCharacter> _enemyObjects_k__BackingField;
		private Target _targets;
	
		// Properties
		public List<EnemyCharacter> enemyObjects { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private class Target
		{
			// Fields
			public List<int> partyIndex;
	
			// Constructors
			public Target();
		}
	
		// Constructors
		public ActionPartsUpthrust(ActionParts resource);
	
		// Methods
		protected override void OnFinish();
		public override void Clear();
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
