using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ButtonEvent_App
{
    delegate void ClickEvent(Button b);

    class Button
    {
        private int _id;
        private string _text;
        public event ClickEvent OnClick;

        public void SetId(int id) { _id = id; }
        public int GetId() { return _id; }

        public void SetText(string text) { _text = text; }
        public string GetText() { return _text; }

        public void Press()
        {
            if (OnClick != null) { OnClick(this); }
        }
    }
}
