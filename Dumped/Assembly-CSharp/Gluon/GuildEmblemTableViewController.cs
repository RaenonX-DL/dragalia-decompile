/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildEmblemTableViewController : TableViewController<int>
	{
		// Fields
		private float cellWidth;
		private float cellHeight;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<GuildEmblemElement, int> __9__4_0;
			public static Func<GuildEmblemElement, bool> __9__4_1;
			public static Func<GuildEmblemElement, int> __9__4_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Start_b__4_0(GuildEmblemElement x);
			internal bool _Start_b__4_1(GuildEmblemElement x);
			internal int _Start_b__4_2(GuildEmblemElement x);
		}
	
		// Constructors
		public GuildEmblemTableViewController();
	
		// Methods
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		protected override void Start();
		protected override TableViewCell<int> CreateCellForIndex(int index);
	}
}
