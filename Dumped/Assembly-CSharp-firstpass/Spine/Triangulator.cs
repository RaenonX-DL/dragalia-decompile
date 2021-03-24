/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	internal class Triangulator
	{
		// Fields
		private readonly ExposedList<ExposedList<float>> convexPolygons;
		private readonly ExposedList<ExposedList<int>> convexPolygonsIndices;
		private readonly ExposedList<int> indicesArray;
		private readonly ExposedList<bool> isConcaveArray;
		private readonly ExposedList<int> triangles;
		private readonly Pool<ExposedList<float>> polygonPool;
		private readonly Pool<ExposedList<int>> polygonIndicesPool;
	
		// Constructors
		public Triangulator();
	
		// Methods
		public ExposedList<int> Triangulate(ExposedList<float> verticesArray);
		public ExposedList<ExposedList<float>> Decompose(ExposedList<float> verticesArray, ExposedList<int> triangles);
		private static bool IsConcave(int index, int vertexCount, float[] vertices, int[] indices);
		private static bool PositiveArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y);
		private static int Winding(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y);
	}
}
