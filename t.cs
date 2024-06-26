public class Test
{
	public bool T(bool c)
	{
        if (c)
		{
			T(false);
		}
		return true;
	}

    public event EventHandler SomeEvent
    {
        add
        {
            // add event subscriber here
        }
        remove
        {
            // remove event subscriber here
        }
    }
}
