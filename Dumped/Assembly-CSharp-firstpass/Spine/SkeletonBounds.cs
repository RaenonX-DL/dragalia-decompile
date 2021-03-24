/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class SkeletonBounds
	{
		// Fields
		private ExposedList<Polygon> polygonPool;
		private float minX;
		private float minY;
		private float maxX;
		private float maxY;
		[CompilerGenerated]
		private ExposedList<BoundingBoxAttachment> _BoundingBoxes_k__BackingField;
		[CompilerGenerated]
		private ExposedList<Polygon> _Polygons_k__BackingField;
	
		// Properties
		public ExposedList<BoundingBoxAttachment> BoundingBoxes { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ExposedList<Polygon> Polygons { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float MinX { get; set; }
		public float MinY { get; set; }
		public float MaxX { get; set; }
		public float MaxY { get; set; }
		public float Width { get; }
		public float Height { get; }
	
		// Constructors
		public SkeletonBounds();
	
		// Methods
		public void Update(Skeleton skeleton, bool updateAabb);
		private void AabbCompute();
		public bool AabbContainsPoint(float x, float y);
		public bool AabbIntersectsSegment(float x1, float y1, float x2, float y2);
		public bool AabbIntersectsSkeleton(SkeletonBounds bounds);
		public bool ContainsPoint(Polygon polygon, float x, float y);
		public BoundingBoxAttachment ContainsPoint(float x, float y);
		public BoundingBoxAttachment IntersectsSegment(float x1, float y1, float x2, float y2);
		public bool IntersectsSegment(Polygon polygon, float x1, float y1, float x2, float y2);
		public Polygon GetPolygon(BoundingBoxAttachment attachment);
	}
}
