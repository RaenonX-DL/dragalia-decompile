/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class Skeleton
	{
		// Fields
		internal SkeletonData data;
		internal ExposedList<Bone> bones;
		internal ExposedList<Slot> slots;
		internal ExposedList<Slot> drawOrder;
		internal ExposedList<IkConstraint> ikConstraints;
		internal ExposedList<TransformConstraint> transformConstraints;
		internal ExposedList<PathConstraint> pathConstraints;
		internal ExposedList<IUpdatable> updateCache;
		internal ExposedList<Bone> updateCacheReset;
		internal Skin skin;
		internal float r;
		internal float g;
		internal float b;
		internal float a;
		internal float time;
		internal bool flipX;
		internal bool flipY;
		internal float x;
		internal float y;
	
		// Properties
		public SkeletonData Data { get; }
		public ExposedList<Bone> Bones { get; }
		public ExposedList<IUpdatable> UpdateCacheList { get; }
		public ExposedList<Slot> Slots { get; }
		public ExposedList<Slot> DrawOrder { get; }
		public ExposedList<IkConstraint> IkConstraints { get; }
		public ExposedList<PathConstraint> PathConstraints { get; }
		public ExposedList<TransformConstraint> TransformConstraints { get; }
		public Skin Skin { get; set; }
		public float R { get; set; }
		public float G { get; set; }
		public float B { get; set; }
		public float A { get; set; }
		public float Time { get; set; }
		public float X { get; set; }
		public float Y { get; set; }
		public bool FlipX { get; set; }
		public bool FlipY { get; set; }
		public Bone RootBone { get; }
	
		// Constructors
		public Skeleton(SkeletonData data);
	
		// Methods
		public void UpdateCache();
		private void SortIkConstraint(IkConstraint constraint);
		private void SortPathConstraint(PathConstraint constraint);
		private void SortTransformConstraint(TransformConstraint constraint);
		private void SortPathConstraintAttachment(Skin skin, int slotIndex, Bone slotBone);
		private void SortPathConstraintAttachment(Attachment attachment, Bone slotBone);
		private void SortBone(Bone bone);
		private static void SortReset(ExposedList<Bone> bones);
		public void UpdateWorldTransform();
		public void SetToSetupPose();
		public void SetBonesToSetupPose();
		public void SetSlotsToSetupPose();
		public Bone FindBone(string boneName);
		public int FindBoneIndex(string boneName);
		public Slot FindSlot(string slotName);
		public int FindSlotIndex(string slotName);
		public void SetSkin(string skinName);
		public void SetSkin(Skin newSkin);
		public Attachment GetAttachment(string slotName, string attachmentName);
		public Attachment GetAttachment(int slotIndex, string attachmentName);
		public void SetAttachment(string slotName, string attachmentName);
		public IkConstraint FindIkConstraint(string constraintName);
		public TransformConstraint FindTransformConstraint(string constraintName);
		public PathConstraint FindPathConstraint(string constraintName);
		public void Update(float delta);
		public void GetBounds(out float x, out float y, out float width, out float height, ref float[] vertexBuffer);
	}
}
