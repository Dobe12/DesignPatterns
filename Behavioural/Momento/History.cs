using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    class History
    {
        public Stack<EditorState> States = new Stack<EditorState>();
    }
}
