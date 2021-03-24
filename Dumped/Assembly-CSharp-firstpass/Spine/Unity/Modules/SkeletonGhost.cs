/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	[RequireComponent]
	public class SkeletonGhost : MonoBehaviour
	{
		// Fields
		private const HideFlags GhostHideFlags = HideFlags.None | HideFlags.HideInHierarchy;
		private const string GhostingShaderName = "Spine/Special/SkeletonGhost";
		public bool ghostingEnabled;
		public float spawnRate;
		public Color32 color;
		[Tooltip]
		public bool additive;
		public int maximumGhosts;
		public float fadeSpeed;
		public Shader ghostShader;
		[Range]
		[Tooltip]
		public float textureFade;
		[Header]
		public bool sortWithDistanceOnly;
		public float zOffset;
		private float nextSpawnTime;
		private SkeletonGhostRenderer[] pool;
		private int poolIndex;
		private SkeletonRenderer skeletonRenderer;
		private MeshRenderer meshRenderer;
		private MeshFilter meshFilter;
		private readonly Dictionary<Material, Material> materialTable;
	
		// Constructors
		public SkeletonGhost();
	
		// Methods
		private void Start();
		private void OnEvent(TrackEntry trackEntry, Spine.Event e);
		private void Ghosting(float val);
		private void Update();
		private void OnDestroy();
		private static Color32 HexToColor(string hex);
	}
}
