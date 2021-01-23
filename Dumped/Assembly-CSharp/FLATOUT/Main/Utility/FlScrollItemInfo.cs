/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlScrollItemInfo
	{
		// Fields
		protected int _index;
		protected int _extendedIndex;
		protected int _objectID;
		protected float _startPosition;
		protected float _centerPosition;
		protected float _endPosition;
		protected FlScrollItemObject _itemObject;
	
		// Properties
		public int Index { get; set; }
		public int ExtendedIndex { get; set; }
		public int ObjectID { get; }
		public float StartPosition { get; set; }
		public float CenterPosition { get; set; }
		public float EndPosition { get; set; }
		public FlScrollItemObject ItemObject { get; set; }
	
		// Constructors
		public FlScrollItemInfo();
	
		// Methods
		public void SetObjectID(int id);
	}
}
