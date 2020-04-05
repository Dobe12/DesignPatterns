using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    class EditorState
    {
        public string Content { get; private set; }
        public DateTime CreatingTime { get; set; }

        public EditorState(string content)
        {
            Content = content;
            CreatingTime = DateTime.Now;
        }
    }
}
