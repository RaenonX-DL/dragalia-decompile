/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class MoviePlayerForObj : MoviePlayerBase
	{
		// Fields
		[SerializeField]
		private CriManaMovieController movieController;
		[SerializeField]
		private MeshFilter meshFilter;
		[CompilerGenerated]
		private bool _IsTargetForReycast_k__BackingField;
		[SerializeField]
		private GameObject screenObject;
	
		// Properties
		protected override CriManaMovieMaterial MovieController { get; }
		public override string SortingLayerName { get; set; }
		public override int SortingOrder { get; set; }
		public override bool IsTargetForReycast { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override Vector2 ScreenSize { get; set; }
	
		// Constructors
		public MoviePlayerForObj();
	
		// Methods
		protected override void AdjustScreenSize(Vector2 dispRectSize, bool isPanScan);
	}
}
