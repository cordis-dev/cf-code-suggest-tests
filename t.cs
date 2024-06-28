public class Test
{
    public bool Enabled
    {
        get
        {

            return true;
        }
    }

    public bool T(bool c)
    {
        do
        {
            Console.WriteLine("Loop forever");
        }

        while (true);

        if (c)
        {
            T(false);
        }
        return true;
        // Return the value of the 'enabled' field.
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
