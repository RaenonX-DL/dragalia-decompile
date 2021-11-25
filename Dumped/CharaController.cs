using System.Runtime.CompilerServices;
using Cutt;
using UnityEngine;

public class CharaController : MonoBehaviour, ICuttTimelineCharactorLocator
{
	public Transform _headNode;

	public Transform _chestNode;

	public Transform _footNode;

	public Transform _positionNode;

	public Animation _animation;

	private CuttCharaPosition _cuttCharaStandingPosition;

	private Vector3 _cuttCharaInitialPosition;

	public bool cuttCharaVisible
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public CuttCharaPosition cuttCharaStandingPosition
	{
		get
		{
			return default(CuttCharaPosition);
		}
		set
		{
		}
	}

	public Vector3 cuttCharaInitialPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 cuttCharaHeadPosition => default(Vector3);

	public Vector3 cuttCharaChestPosition => default(Vector3);

	public Vector3 cuttCharaFootPosition => default(Vector3);

	public Animation cuttAnimationComponent => null;

	public Transform cuttRootTransform => null;

	public int cuttCharaHeightLevel
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float cuttCharaHeightValue => default(float);

	public float cuttCharaHeightRatio
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}
}
