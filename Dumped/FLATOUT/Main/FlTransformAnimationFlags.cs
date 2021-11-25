namespace FLATOUT.Main
{
	public enum FlTransformAnimationFlags
	{
		Position = 1,
		PositionX = 2,
		PositionY = 4,
		PositionZ = 8,
		PositionOffset = 0x10,
		PositionOffsetX = 0x20,
		PositionOffsetY = 0x40,
		PositionOffsetZ = 0x80,
		Rotate = 0x100,
		RotateX = 0x200,
		RotateY = 0x400,
		RotateZ = 0x800,
		Scale = 0x1000,
		ScaleX = 0x2000,
		ScaleY = 0x4000,
		ScaleZ = 0x8000,
		Shear = 0x10000,
		ShearX = 0x20000,
		ShearY = 0x40000
	}
}
