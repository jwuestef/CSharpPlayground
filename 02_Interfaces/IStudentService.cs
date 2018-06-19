using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces
{
    public interface IStudentService
    {

        // CRUD methods, I think this is just a list of method signatures - the implementation (the actual code between the curly braces) is elsewhere

        void PrintNameAndEmail();
        void PrintNameBackwards();
        void SpeakNameThroughSpeechSynthesis();

    }
}
