using System.Runtime.CompilerServices;

public class CriFsLoadFileRequest : CriFsRequest
{
	private enum Phase
	{
		Stop,
		Bind,
		Load,
		Done,
		Error
	}

	private Phase phase;

	private CriFsBinder refBinder;

	private CriFsBinder newBinder;

	private uint bindId;

	private CriFsLoader loader;

	private int readUnitSize;

	private long fileSize;

	public string path
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public byte[] bytes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override void Stop()
	{
	}

	public override void Update()
	{
	}

	private void UpdateBinder()
	{
	}

	private void UpdateLoader()
	{
	}

	private void OnError()
	{
	}
}
