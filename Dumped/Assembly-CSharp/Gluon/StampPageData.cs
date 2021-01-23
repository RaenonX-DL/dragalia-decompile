/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampPageData
	{
		// Fields
		public const int maxIconCount = 8;
		public int stampSetID;
		public int[] selectStampIDs;
		public int selectIndex;
	
		// Constructors
		public StampPageData();
	
		// Methods
		public void ResetSelectIndex();
		public void Remove(int selectPageIconIndex);
	}
}
