using CapitalPlacement.Enums;
using CapitalPlacement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Utilities
{
    internal class QuestionBuilder
    {
        public static Question Create(QuestionType type)
        {
            var question = type switch
            {
                QuestionType.Dropdown => new DropDownQuestion(),
                QuestionType.Multiple_Choice => new MultipleChoiceQuestion(),
                _ => new Question()
            };

            question.Type = type;

            return question;
        }
    }
}
