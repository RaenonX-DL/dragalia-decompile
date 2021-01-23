/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class RegionAttachment : Attachment, IHasRendererObject
	{
		// Fields
		public const int BLX = 0;
		public const int BLY = 1;
		public const int ULX = 2;
		public const int ULY = 3;
		public const int URX = 4;
		public const int URY = 5;
		public const int BRX = 6;
		public const int BRY = 7;
		internal float x;
		internal float y;
		internal float rotation;
		internal float scaleX;
		internal float scaleY;
		internal float width;
		internal float height;
		internal float regionOffsetX;
		internal float regionOffsetY;
		internal float regionWidth;
		internal float regionHeight;
		internal float regionOriginalWidth;
		internal float regionOriginalHeight;
		internal float[] offset;
		internal float[] uvs;
		internal float r;
		internal float g;
		internal float b;
		internal float a;
		[CompilerGenerated]
		private string _Path_k__BackingField;
		[CompilerGenerated]
		private object _RendererObject_k__BackingField;
	
		// Properties
		public float X { get; set; }
		public float Y { get; set; }
		public float Rotation { get; set; }
		public float ScaleX { get; set; }
		public float ScaleY { get; set; }
		public float Width { get; set; }
		public float Height { get; set; }
		public float R { get; set; }
		public float G { get; set; }
		public float B { get; set; }
		public float A { get; set; }
		public string Path { [CompilerGenerated] get; [CompilerGenerated] set; }
		public object RendererObject { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float RegionOffsetX { get; set; }
		public float RegionOffsetY { get; set; }
		public float RegionWidth { get; set; }
		public float RegionHeight { get; set; }
		public float RegionOriginalWidth { get; set; }
		public float RegionOriginalHeight { get; set; }
		public float[] Offset { get; }
		public float[] UVs { get; }
	
		// Constructors
		public RegionAttachment(string name);
	
		// Methods
		public void UpdateOffset();
		public void SetUVs(float u, float v, float u2, float v2, bool rotate);
		public void ComputeWorldVertices(Bone bone, float[] worldVertices, int offset, int stride = 2);
	}
}
