using System;
using System.Collections.Generic;

namespace familyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Jim"},
                {"age", "40"}
            });
            myFamily.Add("Mother", new Dictionary<string, string>(){
                {"name", "Sharilyn"},
                {"age", "73"}
            });
            myFamily.Add("Father", new Dictionary<string, string>(){
                {"name", "David"},
                {"age", "75"}
            });

            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
                {
                    string name = "";
                    string age = "";

                    foreach(KeyValuePair<string, string> memberspecifics in familyMember.Value) {
                        if(memberspecifics.Key == "name") {
                            name = memberspecifics.Value;
                        } else {
                            age = memberspecifics.Value;
                        }
                    };
                    Console.WriteLine($"{name} is my {familyMember.Key} and is {age} years old. ");
                };


        }
    }
}
