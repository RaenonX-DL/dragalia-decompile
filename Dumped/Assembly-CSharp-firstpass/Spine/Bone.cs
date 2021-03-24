/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class Bone : IUpdatable
	{
		// Fields
		public static bool yDown;
		internal BoneData data;
		internal Skeleton skeleton;
		internal Bone parent;
		internal ExposedList<Bone> children;
		internal float x;
		internal float y;
		internal float rotation;
		internal float scaleX;
		internal float scaleY;
		internal float shearX;
		internal float shearY;
		internal float ax;
		internal float ay;
		internal float arotation;
		internal float ascaleX;
		internal float ascaleY;
		internal float ashearX;
		internal float ashearY;
		internal bool appliedValid;
		internal float a;
		internal float b;
		internal float worldX;
		internal float c;
		internal float d;
		internal float worldY;
		internal bool sorted;
	
		// Properties
		public BoneData Data { get; }
		public Skeleton Skeleton { get; }
		public Bone Parent { get; }
		public ExposedList<Bone> Children { get; }
		public float X { get; set; }
		public float Y { get; set; }
		public float Rotation { get; set; }
		public float ScaleX { get; set; }
		public float ScaleY { get; set; }
		public float ShearX { get; set; }
		public float ShearY { get; set; }
		public float AppliedRotation { get; set; }
		public float AX { get; set; }
		public float AY { get; set; }
		public float AScaleX { get; set; }
		public float AScaleY { get; set; }
		public float AShearX { get; set; }
		public float AShearY { get; set; }
		public float A { get; }
		public float B { get; }
		public float C { get; }
		public float D { get; }
		public float WorldX { get; }
		public float WorldY { get; }
		public float WorldRotationX { get; }
		public float WorldRotationY { get; }
		public float WorldScaleX { get; }
		public float WorldScaleY { get; }
		public float WorldToLocalRotationX { get; }
		public float WorldToLocalRotationY { get; }
	
		// Constructors
		public Bone(BoneData data, Skeleton skeleton, Bone parent);
	
		// Methods
		public void Update();
		public void UpdateWorldTransform();
		public void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY);
		public void SetToSetupPose();
		internal void UpdateAppliedTransform();
		public void WorldToLocal(float worldX, float worldY, out float localX, out float localY);
		public void LocalToWorld(float localX, float localY, out float worldX, out float worldY);
		public float WorldToLocalRotation(float worldRotation);
		public float LocalToWorldRotation(float localRotation);
		public void RotateWorld(float degrees);
		public override string ToString();
	}
}
