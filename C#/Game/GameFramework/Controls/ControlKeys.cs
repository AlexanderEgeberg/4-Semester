namespace GameFramework
{
    public class LeftKey : IKey
    {
        public bool CheckKey(char c)
        {
            if (c == 'a')
            {
                return true;
            }
            return false;
        }

        public InputKey ReturnKey()
        {
            return InputKey.LEFT;
        }

    }

    public class RightKey : IKey
    {
        public bool CheckKey(char c)
        {
            if (c == 'd')
            {
                return true;
            }
            return false;
        }

        public InputKey ReturnKey()
        {
            return InputKey.RIGHT;
        }

    }
    public class BackKey : IKey
    {
        public bool CheckKey(char c)
        {
            if (c == 'd')
            {
                return true;
            }
            return false;
        }

        public InputKey ReturnKey()
        {
            return InputKey.BACK;
        }

    }
    public class ForwardKey : IKey
    {
        public bool CheckKey(char c)
        {
            if (c == 'w')
            {
                return true;
            }
            return false;
        }

        public InputKey ReturnKey()
        {
            return InputKey.FORWARD;
        }

    }
    public class UseKey : IKey
    {
        public bool CheckKey(char c)
        {
            if (c == 'E')
            {
                return true;
            }
            return false;
        }

        public InputKey ReturnKey()
        {
            return InputKey.USE;
        }

    }
}