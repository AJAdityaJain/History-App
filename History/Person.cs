using System;

namespace History
{
    class Person
    {

        public static int GID = 1;

        public int ID;
        public string name;
        public DateTime start, end;
        public bool eb;
        public string desc;
        public string uri;

        public Person(int ID,string name, DateTime start, DateTime end, string desc, string uri, bool eb)
        {
            this.ID = ID;
            this.name = name;
            this.start = start;
            this.end = end;
            this.desc = desc;
            this.uri = uri;
            this.eb = eb;
        }
        public Person(string name, DateTime start, DateTime end, string desc,string uri, bool eb)
        {
            this.ID = GID;
            GID++;
            this.name = name;
            this.start = start;
            this.end = end;
            this.desc = desc;
            this.uri = uri;
            this.eb = eb;
        }

        public string toString()
        {
            string r = "";

            r += ID + "$";
            r += name + "$";
            r += start.ToString() + "$";
            r += end.ToString() + "$";
            r += desc + "$";
            r += uri + "$";
            r += eb.ToString();

            return r;
        }
    }
}