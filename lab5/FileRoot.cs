using System;
namespace lab5
{
    public class FileRoot
    {
        public static string projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
    }
}

