/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class VertexAttachment : Attachment
	{
		// Fields
		private static int nextID;
		private static readonly object nextIdLock;
		internal readonly int id;
		internal int[] bones;
		internal float[] vertices;
		internal int worldVerticesLength;
	
		// Properties
		public int Id { get; }
		public int[] Bones { get; set; }
		public float[] Vertices { get; set; }
		public int WorldVerticesLength { get; set; }
	
		// Constructors
		public VertexAttachment(string name);
		static VertexAttachment();
	
		// Methods
		public void ComputeWorldVertices(Slot slot, float[] worldVertices);
		public void ComputeWorldVertices(Slot slot, int start, int count, float[] worldVertices, int offset, int stride = 2);
		public virtual bool ApplyDeform(VertexAttachment sourceAttachment);
	}
}
