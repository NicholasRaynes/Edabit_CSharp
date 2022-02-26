using System;

namespace GitHubSandbox
{
    public class ParseArrayProgram
    {
        public static string[] ParseArray(object[] arr)
        {
            string[] newArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                string str = arr[i] + " ";

                newArr[i] = str.Replace(" ", "");
            }

            return newArr;
        }
    }
}
