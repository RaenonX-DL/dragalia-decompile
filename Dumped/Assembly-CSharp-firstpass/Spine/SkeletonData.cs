/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class SkeletonData
	{
		// Fields
		internal string name;
		internal ExposedList<BoneData> bones;
		internal ExposedList<SlotData> slots;
		internal ExposedList<Skin> skins;
		internal Skin defaultSkin;
		internal ExposedList<EventData> events;
		internal ExposedList<Animation> animations;
		internal ExposedList<IkConstraintData> ikConstraints;
		internal ExposedList<TransformConstraintData> transformConstraints;
		internal ExposedList<PathConstraintData> pathConstraints;
		internal float width;
		internal float height;
		internal string version;
		internal string hash;
		internal float fps;
		internal string imagesPath;
	
		// Properties
		public string Name { get; set; }
		public ExposedList<BoneData> Bones { get; }
		public ExposedList<SlotData> Slots { get; }
		public ExposedList<Skin> Skins { get; set; }
		public Skin DefaultSkin { get; set; }
		public ExposedList<EventData> Events { get; set; }
		public ExposedList<Animation> Animations { get; set; }
		public ExposedList<IkConstraintData> IkConstraints { get; set; }
		public ExposedList<TransformConstraintData> TransformConstraints { get; set; }
		public ExposedList<PathConstraintData> PathConstraints { get; set; }
		public float Width { get; set; }
		public float Height { get; set; }
		public string Version { get; set; }
		public string Hash { get; set; }
		public string ImagesPath { get; set; }
		public float Fps { get; set; }
	
		// Constructors
		public SkeletonData();
	
		// Methods
		public BoneData FindBone(string boneName);
		public int FindBoneIndex(string boneName);
		public SlotData FindSlot(string slotName);
		public int FindSlotIndex(string slotName);
		public Skin FindSkin(string skinName);
		public EventData FindEvent(string eventDataName);
		public Animation FindAnimation(string animationName);
		public IkConstraintData FindIkConstraint(string constraintName);
		public TransformConstraintData FindTransformConstraint(string constraintName);
		public PathConstraintData FindPathConstraint(string constraintName);
		public int FindPathConstraintIndex(string pathConstraintName);
		public override string ToString();
	}
}
