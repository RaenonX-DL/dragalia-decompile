/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MiniMapParam : MonoBehaviour
	{
		// Fields
		public const float MapPartsScale = 4f;
		private Rect _mapRect;
		private SpriteRenderer _image;
		private MiniMapParam[] _params;
		private float _disruptAlpha;
		private static float DiscoverryAlpha;
		private static float AnimationTime;
		private ProgressSearch _searchState;
		private static Vector3 DefaultScale;
	
		// Properties
		public Rect MapRect { get; }
		public SpriteRenderer Image { get; }
		public bool IsIntrusion { get; }
		public ProgressSearch SearchState { get; set; }
	
		// Nested types
		public enum ProgressSearch
		{
			Unexplored = 0,
			Discoverry = 1,
			Intrusion = 2
		}
	
		// Constructors
		public MiniMapParam();
		static MiniMapParam();
	
		// Methods
		private void Awake();
		public void Initialize(Vector2 pos, Rect viewRect);
		private void SetColorAlpha(float alpha, bool isAnim = true);
		private void SetIntrusion();
		public bool IsIntrusionArea(Vector2 pos);
		public void UpdateState(Vector2 pos);
		private void OnUpdateAlpha(float value);
		public void SetDrawFlag(bool drawFlag);
		public void SetAlwaysDraw();
	}
}
