/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingSearchBlock : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image[] colorBlocks;
		private int[] blockOnTable;
		private int blockIndex;
		private int blockUpdateCount;
		private const int blockUpdateFrame = 2;
		private Color blockColorOn;
		private Color blockColorOff;
	
		// Constructors
		public MatchingSearchBlock();
	
		// Methods
		public override void FastUpdate();
	}
}
