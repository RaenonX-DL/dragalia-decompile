/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class SkeletonClipping
	{
		// Fields
		internal readonly Triangulator triangulator;
		internal readonly ExposedList<float> clippingPolygon;
		internal readonly ExposedList<float> clipOutput;
		internal readonly ExposedList<float> clippedVertices;
		internal readonly ExposedList<int> clippedTriangles;
		internal readonly ExposedList<float> clippedUVs;
		internal readonly ExposedList<float> scratch;
		internal ClippingAttachment clipAttachment;
		internal ExposedList<ExposedList<float>> clippingPolygons;
	
		// Properties
		public ExposedList<float> ClippedVertices { get; }
		public ExposedList<int> ClippedTriangles { get; }
		public ExposedList<float> ClippedUVs { get; }
		public bool IsClipping { get; }
	
		// Constructors
		public SkeletonClipping();
	
		// Methods
		public int ClipStart(Slot slot, ClippingAttachment clip);
		public void ClipEnd(Slot slot);
		public void ClipEnd();
		public void ClipTriangles(float[] vertices, int verticesLength, int[] triangles, int trianglesLength, float[] uvs);
		internal bool Clip(float x1, float y1, float x2, float y2, float x3, float y3, ExposedList<float> clippingArea, ExposedList<float> output);
		private static void MakeClockwise(ExposedList<float> polygon);
	}
}
