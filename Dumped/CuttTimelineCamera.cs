using Cutt;
using UnityEngine;

public class CuttTimelineCamera : MonoBehaviour
{
	private bool _applyNoise;

	public float positionFrequency;

	public float rotationFrequency;

	public float positionAmount;

	public float rotationAmount;

	public Vector3 positionComponents;

	public Vector3 rotationComponents;

	private int positionOctave;

	private int rotationOctave;

	private float timePosition;

	private float timeRotation;

	private float initTimePosition;

	private float initTimeRotation;

	private float timeOffsetTouchWait;

	private Vector2[] noiseVectors;

	private Camera _attachedCamera;

	private CuttTimelineControl _timelineControl;

	private Vector3 posOffset;

	private Quaternion rotOffset;

	public bool applyNoise
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static float kPositionAmountInitVal => default(float);

	public static float kRotationAmountInitVal => default(float);

	public static Vector3 kPositionComponentsInitVal => default(Vector3);

	public static Vector3 kRotationComponentsInitVal => default(Vector3);

	private Camera attachedCamera => null;

	public void Initialize(CuttTimelineControl ctrl)
	{
	}

	public void AlterAwake()
	{
	}

	public void AlterUpdate(float time)
	{
	}

	private static float Fbm(Vector2 coord, int octave)
	{
		return default(float);
	}

	private void OnPreCull()
	{
	}
}
