using System;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.States.Push(editor.Save());

            editor.Content = "b";
            history.States.Push(editor.Save());

            editor.Content = "c";
            editor.Restore(history.States.Pop());

            Console.Write(editor.Content);
        }
    }
}
