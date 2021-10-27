/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumPictureBookMedalGroupController : TableViewController<Gluon.AlbumPictureBookMedalCellGroupData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<HonorDataElement> __9__2_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadMedalList_b__2_0(HonorDataElement a, HonorDataElement b);
		}
	
		// Constructors
		public AlbumPictureBookMedalGroupController();
	
		// Methods
		public void LoadMedalList();
		protected override TableViewCell<AlbumPictureBookMedalCellGroupData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
	}
}
