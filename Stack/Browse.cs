using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    internal class Browse
    {
        private string actual = "vazia";
        private readonly Stack<string> historyPrevious = new Stack<string>();
        private readonly Stack<string> historyNext = new Stack<string>();

        public Browse()
        {
            Console.WriteLine($"Actual page: {actual}");
        }

        internal void NavigateTo(string url)
        {
            historyPrevious.Push(actual);
            actual = url;

            Console.WriteLine($"Actual page: {actual}");
        }

        internal void ReturnPage()
        {
            if (historyPrevious.Any())
            {
                historyNext.Push(actual);
                actual = historyPrevious.Pop();
                Console.WriteLine($"Actual page: {actual}");
            }
        }

        internal void NextPage()
        {
            if (historyNext.Any())
            {
                historyPrevious.Push(actual);
                actual = historyNext.Pop();
                Console.WriteLine($"Actual page: {actual}");
            }
        }
    }
}