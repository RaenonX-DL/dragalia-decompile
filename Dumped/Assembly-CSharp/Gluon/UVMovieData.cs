/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CreateAssetMenu]
	public class UVMovieData : ScriptableObject
	{
		// Fields
		public Texture2D[] textures;
		public int fremePerWidth;
		public int fremePerHeight;
		public int frameTotalCount;
		public float fps;
		public float startOffsetSec;
		public float endOffsetSec;
		public bool isLoop;
		public float startLoopSec;
		public float endLoopSec;
		public int loopCount;
	
		// Constructors
		public UVMovieData();
	}
}
