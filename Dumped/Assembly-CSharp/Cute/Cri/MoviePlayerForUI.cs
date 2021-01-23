/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class MoviePlayerForUI : MoviePlayerBase
	{
		// Fields
		[SerializeField]
		private CriManaMovieControllerForUI movieController;
		[SerializeField]
		private RawImage rawImage;
		[SerializeField]
		private RectTransform screenRect;
	
		// Properties
		protected override CriManaMovieMaterial MovieController { get; }
		public override string SortingLayerName { get; set; }
		public override int SortingOrder { get; set; }
		public override bool IsTargetForReycast { get; set; }
		public override Vector2 ScreenSize { get; set; }
	
		// Constructors
		public MoviePlayerForUI();
	
		// Methods
		protected override void AdjustScreenSize(Vector2 dispRectSize, bool isPanScan);
	}
}
