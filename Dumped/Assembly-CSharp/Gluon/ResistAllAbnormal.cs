/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ResistAllAbnormal
	{
		// Fields
		private BitArray flags;
		[CompilerGenerated]
		private CharacterBase _owner_k__BackingField;
	
		// Properties
		public CharacterBase owner { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum SourceType
		{
			All = 0,
			ActionParts = 1,
			BoundaryAction = 2,
			BerserkAbirity = 3,
			IronWall = 4,
			Buff = 5,
			Init = 6
		}
	
		// Constructors
		public ResistAllAbnormal(CharacterBase chara);
	
		// Methods
		public void Clear();
		public void Set(bool flag, SourceType type = SourceType.All);
		public bool Get(SourceType type);
		public bool Any();
	}
}
