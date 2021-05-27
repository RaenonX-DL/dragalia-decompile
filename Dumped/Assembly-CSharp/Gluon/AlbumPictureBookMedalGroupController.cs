/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumPictureBookMedalGroupController : TableViewController<Gluon.AlbumPictureBookMedalCellGroupData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
	
		// Constructors
		public AlbumPictureBookMedalGroupController();
	
		// Methods
		public void LoadMedalList();
		protected override TableViewCell<AlbumPictureBookMedalCellGroupData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
	}
}
