/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace usmooth
{
	public class DataCollector
	{
		// Fields
		public static DataCollector Instance;
		public static GameObject MainCamera;
		private FrameData _currentFrame;
		private List<FrameData> _frames;
		private MeshLut _meshLut;
		private Dictionary<Material, HashSet<GameObject>> _visibleMaterials;
		private Dictionary<Texture, HashSet<Material>> _visibleTextures;
		private Dictionary<int, string> _nameLut;
		private Dictionary<Texture, int> _textureSizeLut;
	
		// Properties
		public MeshLut MeshTable { get; }
		public Dictionary<Material, HashSet<GameObject>> VisibleMaterials { get; }
		public Dictionary<Texture, HashSet<Material>> VisibleTextures { get; }
	
		// Constructors
		public DataCollector();
		static DataCollector();
	
		// Methods
		public FrameData CollectFrameData();
		public void WriteName(int instID, UsCmd cmd);
		private void AddVisibleMaterial(Material mat, GameObject gameobject);
		private void AddVisibleTexture(Texture texture, Material ownerMat);
		public void DumpAllInfo();
		public UsCmd CreateMaterialCmd();
		public UsCmd CreateTextureCmd();
	}
}
