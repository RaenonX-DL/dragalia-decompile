using UnityEngine;

namespace FLATOUT.Main
{
	public class FlObject : FlObjectBase
	{
		private FlObjectParameter _objParam;

		private FlMotion _childMotion;

		private bool _existChildMotion;

		public FlObjectParameter ObjectParameter => null;

		public FlMotion ChildMotion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ExistChildMotion => default(bool);

		public FlObject(GameObject gameObject)
		{
		}

		public override void _CreateEditorData(FlObjectParameterBase parameter, FlMotion parentMotion)
		{
		}

		public override void _ApplyData(FlObjectParameterBase parameter, FlMotion parentMotion)
		{
		}

		public override void _CreateData()
		{
		}

		public override void _FixData()
		{
		}

		public override void _Update()
		{
		}

		public override void _UpdateForce()
		{
		}

		protected override void _UpdateColor()
		{
		}

		protected override void _UpdateTransform()
		{
		}

		public override void _UpdateStencilRef(bool children)
		{
		}

		protected override void _SetGrayscaleBase(bool enable)
		{
		}

		public override void _ResetTime()
		{
		}

		public override void SetSortOffset(int sortOffset)
		{
		}

		public override void SetSortLayer(string sortLayerName)
		{
		}

		public override void SetTimeModeType(FlTimeModeTypes timeModeType, bool affectChildren)
		{
		}

		public override void SetMotionSpeed(float speed, bool affectChildren)
		{
		}

		public override void SetColliderThrough(bool through, bool affectChildren)
		{
		}

		public override void SetColliderThicknessOffset(float thicknessOffset, bool affectChildren)
		{
		}

		public override void _UpdateColliderThickness(bool affectChildren)
		{
		}

		public override void SetEnableCollider(bool enable, bool affectChildren)
		{
		}

		public override void SetSubCollider(Collider subCollider, bool affectChildren)
		{
		}

		public override void SetBlurQuality(int blurQuality, int blurPrecision, bool affectChildren)
		{
		}

		public override void SetBlurValue(Vector2 blurValue, bool affectChildren)
		{
		}
	}
}
