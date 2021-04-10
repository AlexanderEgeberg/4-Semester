using System;
using System.Collections.Generic;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.singleton
{
    class NoteCatalogue
    {
        //singleton
        //step 1
        private static NoteCatalogue instance = new NoteCatalogue();

        // step 2
        public static NoteCatalogue Instance => instance;

        // step 3
        private NoteCatalogue()
        {
            this.notes = new List<string>()
            {
                "note1", "note2", "and note3"
            };
        }

        // End singleton


        private List<String> notes;

        public List<string> Notes => new List<string>(notes);



        public void Add(string item)
        {
            notes.Add(item);
        }

        public void Clear()
        {
            notes.Clear();
        }


        public override string ToString()
        {
            String strNotes = String.Join("\n", notes);
            return $"Notes are :\n{strNotes}";
        }
    }
}
