/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class MeshAttachment : VertexAttachment, IHasRendererObject
	{
		// Fields
		internal float regionOffsetX;
		internal float regionOffsetY;
		internal float regionWidth;
		internal float regionHeight;
		internal float regionOriginalWidth;
		internal float regionOriginalHeight;
		private MeshAttachment parentMesh;
		internal float[] uvs;
		internal float[] regionUVs;
		internal int[] triangles;
		internal float r;
		internal float g;
		internal float b;
		internal float a;
		internal int hulllength;
		internal bool inheritDeform;
		[CompilerGenerated]
		private string _Path_k__BackingField;
		[CompilerGenerated]
		private object _RendererObject_k__BackingField;
		[CompilerGenerated]
		private float _RegionU_k__BackingField;
		[CompilerGenerated]
		private float _RegionV_k__BackingField;
		[CompilerGenerated]
		private float _RegionU2_k__BackingField;
		[CompilerGenerated]
		private float _RegionV2_k__BackingField;
		[CompilerGenerated]
		private bool _RegionRotate_k__BackingField;
		[CompilerGenerated]
		private int[] _Edges_k__BackingField;
		[CompilerGenerated]
		private float _Width_k__BackingField;
		[CompilerGenerated]
		private float _Height_k__BackingField;
	
		// Properties
		public int HullLength { get; set; }
		public float[] RegionUVs { get; set; }
		public float[] UVs { get; set; }
		public int[] Triangles { get; set; }
		public float R { get; set; }
		public float G { get; set; }
		public float B { get; set; }
		public float A { get; set; }
		public string Path { [CompilerGenerated] get; [CompilerGenerated] set; }
		public object RendererObject { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float RegionU { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float RegionV { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float RegionU2 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float RegionV2 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool RegionRotate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float RegionOffsetX { get; set; }
		public float RegionOffsetY { get; set; }
		public float RegionWidth { get; set; }
		public float RegionHeight { get; set; }
		public float RegionOriginalWidth { get; set; }
		public float RegionOriginalHeight { get; set; }
		public bool InheritDeform { get; set; }
		public MeshAttachment ParentMesh { get; set; }
		public int[] Edges { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float Width { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float Height { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public MeshAttachment(string name);
	
		// Methods
		public void UpdateUVs();
		public override bool ApplyDeform(VertexAttachment sourceAttachment);
	}
}
