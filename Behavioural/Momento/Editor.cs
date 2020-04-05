using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    class Editor
    {
        public string Content { get; set; }

        public EditorState Save()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }

    }
}
