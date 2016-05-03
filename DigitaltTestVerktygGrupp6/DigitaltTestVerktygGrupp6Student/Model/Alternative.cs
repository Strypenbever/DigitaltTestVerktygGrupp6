﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaltTestVerktygGrupp6Student.Model
{
    class Alternative
    {
        public virtual bool IsChecked { get; set; }
        protected Question ParentQuestion;
        public virtual string UserText { get; set; }

        public string Text { get; set; }
        public int IsCorrect { get; set; }
        public Alternative(Alternatives alt, Question parentQuestion)
        {
            Text = alt.Text;
            IsCorrect = alt.IsCorrect;
            ParentQuestion = parentQuestion;
        }
    }
}
